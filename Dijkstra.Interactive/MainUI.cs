using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Dijkstra.Core;
using Dijkstra.Implementation;

namespace Dijkstra.Interactive
{
    public partial class MainUI : Form
    {
        private IDistanceCalculator<RailNetwork, City, Route> _distanceCalculator;

        private const string DefaultGraph = "AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7";

        private Dictionary<int, Color> colors
            = new Dictionary<int, Color>()
                  {
                      {1, Color.Black},
                      {2, Color.DarkRed},
                      {3, Color.Red},
                      {4, Color.Orange},
                      {5, Color.Yellow},
                      {6, Color.YellowGreen},
                      {7, Color.DarkGreen},
                      {8, Color.LightSeaGreen},
                      {9, Color.Blue}
                  };
                   
        public MainUI()
        {
            InitializeComponent();
        }

        private void VisualiseGraphClick(object sender, EventArgs e)
        {
            RedrawGraph();
        }

        private bool RedrawGraph()
        {
            try
            {
                panel1.Controls.Clear();
                using (var graphics = panel1.CreateGraphics())
                {
                    graphics.Clear(Color.White);
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                }

                var loader = new RailNetworkDataLoader(textBox1.Text);
                _distanceCalculator = DistanceCalculator<RailNetwork, City, Route>.Create(loader);

                var nodes = _distanceCalculator.Graph.Nodes.Values.ToList();

                DrawNodes(nodes);

                DrawEdges(nodes);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Graph\r\n" + ex);
                return false;
            }
        }

        private void DrawEdges(IList<City> nodes)
        {
            for (int i = 0; i < _distanceCalculator.Graph.NodeCount; i++)
            {
                var ng = nodes[i];

                using (var graphics = panel1.CreateGraphics())
                {
                    foreach (var edge in ng.Edges)
                    {
                        DrawEdge(ng, edge, graphics);
                    }
                }
            }

        }

        private void DrawEdge(City city, Route edge, Graphics graphics)
        {
            var startPoint = panel1.Controls.Find(city.NodeName, false).FirstOrDefault() as Node;
            if (startPoint == null) return;

            var endPoint = panel1.Controls
                               .Find(edge.ConnectedNode.NodeName, false)
                               .FirstOrDefault() as Node;
            if (endPoint == null) return;

            //Each user control representing a Node is 40*40 so 20 in is the center point.
            var x1 = startPoint.Left + 20;
            var y1 = startPoint.Top + 20;
            var x2 = endPoint.Left + 20;
            var y2 = endPoint.Top + 20;
            
            //I want to move the start and end point 30 pixels linearly along the line.

            //d = sqrt((x2-x1)^2 + (y2 - y1)^2) #distance
            var length = GetDistance(x1, y1, x2, y2);
            var snipStart = 40/length;
            var snipEnd = 25/length;

            //x3 = r * x2 + (1 - r) * x1 #find point that divides the segment
            //y3 = r * y2 + (1 - r) * y1 #into the ratio (1-r):r
            var x1A = GetRatioCoordinate(snipStart, x2, x1);
            var y1A = GetRatioCoordinate(snipStart, y2, y1);
            var x2A = GetRatioCoordinate(snipEnd, x1, x2);
            var y2A = GetRatioCoordinate(snipEnd, y1, y2);

            var key = (int) edge.Distance;
            var pen = new Pen(colors[key], key * 2)
                          {
                              EndCap = LineCap.ArrowAnchor
                          };

            graphics.DrawLine(pen, x1A, y1A, x2A, y2A);
        }

        /// <summary>
        /// Gets the ratio coordinate.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <returns></returns>
        private int GetRatioCoordinate(double distance, int c1, int c2)
        {
            return (int)(distance * c1 + (1 - distance) * c2);
        }

        /// <summary>
        /// Gets the distance.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <returns></returns>
        private double GetDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        /// <summary>
        /// Draws the nodes.
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        private void DrawNodes(IList<City> nodes)
        {
            var origin = new Point(panel1.Width / 2, panel1.Height / 2);
            const int radius = 250;
            var angle = 360 / _distanceCalculator.Graph.NodeCount;

            for ( var i = 0; i < _distanceCalculator.Graph.NodeCount; i++)
            {
                DrawNode(radius, angle * i, origin, nodes[i]);
            }

        }

        /// <summary>
        /// Draws the node.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <param name="angle">The angle.</param>
        /// <param name="origin">The origin.</param>
        /// <param name="node">The node.</param>
        private void DrawNode(int radius, int angle, Point origin, INode<City, Route> node)
        {
            var point = GetPoint(radius, angle, origin);

            Node n = new Node
            {
                Name = node.NodeName,
                NodeName = node.NodeName,
                Top = point.Y - 20,
                Left = point.X - 20
            };

            panel1.Controls.Add(n);
        }

        /// <summary>
        /// Gets the point.
        /// </summary>
        /// <param name="radius">The radius.</param>
        /// <param name="angleInDegrees">The angle in degrees.</param>
        /// <param name="origin">The origin.</param>
        /// <returns></returns>
        private Point GetPoint(float radius, float angleInDegrees, Point origin)
        {
            // Convert from degrees to radians via multiplication by PI/180        
            var x = (int)(radius * Math.Cos(angleInDegrees * Math.PI / 180F)) + origin.X;
            var y = (int)(radius * Math.Sin(angleInDegrees * Math.PI / 180F)) + origin.Y;

            return new Point(x, y);
        }

        /// <summary>
        /// Tests the direct route click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TestDirectRouteClick(object sender, EventArgs e)
        {
            if (!RedrawGraph())
                return;

            if(Test1.Checked)
            {
                var distance = _distanceCalculator.CalculateDirectRoute("A", "B", "C");

                MessageBox.Show(string.Format("Output #1: {0}", distance));
            }
            else if (Test2.Checked)
            {
                var distance = _distanceCalculator.CalculateDirectRoute("A", "D");

                MessageBox.Show(string.Format("Output #2: {0}", distance));
            }
            else if (Test3.Checked)
            {
                var distance = _distanceCalculator.CalculateDirectRoute("A", "D", "C");

                MessageBox.Show(string.Format("Output #3: {0}", distance));
            }
            else if (Test4.Checked)
            {
                var distance = _distanceCalculator.CalculateDirectRoute("A", "E", "B", "C", "D");

                MessageBox.Show(string.Format("Output #4: {0}", distance));
            }
            else if (Test5.Checked)
            {
                try
                {
                    var distance = _distanceCalculator.CalculateDirectRoute("A", "E", "D");

                    MessageBox.Show(string.Format("Output #5: {0}", distance));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Output #5: {0}", ex.Message));
                }
            }
            else if (TestDirectRouteCustom.Checked)
            {
                var nodes = TestDirectRouteCustomText.Text.Split('-').ToList();
                var startNode = nodes[0];
                nodes.RemoveAt(0);
                try
                {
                    var distance = _distanceCalculator.CalculateDirectRoute(startNode, nodes.ToArray());

                    MessageBox.Show(string.Format("Output #Custom: {0}", distance));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Output #Custom: {0}", ex.Message));
                }
            }
        }

        /// <summary>
        /// Tests the shortest distance button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TestShortestDistanceButtonClick(object sender, EventArgs e)
        {
            if (!RedrawGraph())
                return;

            if(Test8.Checked)
            {
                var distance = _distanceCalculator.CalculateShortestRoute("A", "C");

                MessageBox.Show(string.Format("Output #8: {0}", distance));
            }
            else if(Test9.Checked)
            {
                var distance = _distanceCalculator.CalculateShortestRouteBackToSelf("B");

                MessageBox.Show(string.Format("Output #9: {0}", distance));
            }
            else if(TestShortestDistanceCustom.Checked)
            {
                try
                {
                    var start = TestShortestDistanceCustomStart.Text;
                    var end = TestShortestDistanceCustomEnd.Text;

                    double distance = 0;
                    if (start == end)
                    {
                        distance = _distanceCalculator.CalculateShortestRouteBackToSelf(start);
                    }
                    else
                    {
                        distance = _distanceCalculator.CalculateShortestRoute(start, end);
                    }


                    MessageBox.Show(string.Format("Output #Custom: {0}", distance));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Output #Custom: {0}", ex.Message));
                }
            }
        }

        /// <summary>
        /// Tests the max node count button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TestMaxNodeCountButtonClick(object sender, EventArgs e)
        {
            if (!RedrawGraph())
                return;

            if(Test6.Checked)
            {
                var paths = _distanceCalculator.FindAllPathsWithMaximumNodeCount("C", "C", 3);

                MessageBox.Show(string.Format("Output #6 {0}", paths));
            }
            else if(TestCustomMaxNodeCount.Checked)
            {
                try
                {
                    var start = TestCustomMaxNodeCountStart.Text;
                    var end = TestCustomMaxNodeCountEnd.Text;
                    var stops = int.Parse(TestCustomMaxNodeCountStops.Text);
                    var paths = _distanceCalculator.FindAllPathsWithMaximumNodeCount(start, end, stops);

                    MessageBox.Show(string.Format("Output #Custom: {0}", paths));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Output #Custom: {0}", ex.Message));
                }
            }
        }

        /// <summary>
        /// Tests the exact node count button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TestExactNodeCountButtonClick(object sender, EventArgs e)
        {
            if (!RedrawGraph())
                return;

            if (Test7.Checked)
            {
                var paths = _distanceCalculator.FindAllPathsWithExactNodeCount("A", "C", 4);

                MessageBox.Show(string.Format("Output #7 {0}", paths));
            }
            else if (TestCustomExactNodeCount.Checked)
            {
                try
                {
                    var start = TestCustomExactNodeCountStart.Text;
                    var end = TestCustomExactNodeCountEnd.Text;
                    var stops = int.Parse(TestCustomExactNodeCountStops.Text);
                    var paths = _distanceCalculator.FindAllPathsWithExactNodeCount(start, end, stops);

                    MessageBox.Show(string.Format("Output #Custom: {0}", paths));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Output #Custom: {0}", ex.Message));
                }
            }
        }

        /// <summary>
        /// Tests the max distance button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TestMaxDistanceButtonClick(object sender, EventArgs e)
        {
            if (!RedrawGraph())
                return;

            if (Test10.Checked)
            {
                var paths = _distanceCalculator.FindAllPathsWithMaximumDistance("C", "C", 30);

                MessageBox.Show(string.Format("Output #10 {0}", paths));
            }
            else if (TestCustomMaxDistance.Checked)
            {
                try
                {
                    var start = TestCustomMaxDistanceStart.Text;
                    var end = TestCustomMaxDistanceEnd.Text;
                    var dist = int.Parse(TestCustomMaxDistanceDistance.Text);
                    var paths = _distanceCalculator.FindAllPathsWithMaximumDistance(start, end, dist);

                    MessageBox.Show(string.Format("Output #Custom: {0}", paths));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Output #Custom: {0}", ex.Message));
                }
            }
        }

        
    }
}
