using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Dijkstra.Core;

namespace Dijkstra.Implementation
{
    /// <summary>
    /// Implementation of Dijkstra's Algorithm for find the shortest path through a weighted node graph.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU">The type of the U.</typeparam>
    /// <typeparam name="TV">The type of the V.</typeparam>
    public class DistanceCalculator<T, TU, TV> : IDistanceCalculator<T, TU, TV>
        where T : class,IGraph<TU, TV>, new() 
        where TU : class,INode<TU, TV>
        where TV : class,IEdge<TU, TV>
    {
        /// <summary>
        /// Gets the rail network.
        /// </summary>
        /// <value>
        /// The rail network.
        /// </value>
        public T Graph { get; private set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="DistanceCalculator{T, TU, TV}" /> class from being created.
        /// </summary>
        /// <param name="loader">The loader.</param>
        private DistanceCalculator(IGraphDataLoader loader)
        {
            Graph = new T();

            foreach (var node in loader.GetNodes())
            {
                Graph.AddNode(node);
            }

            foreach (var tuple in loader.GetEdges())
            {                
                Graph.AddEdge(tuple.Item1, tuple.Item2, tuple.Item3);
            }
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public static DistanceCalculator<T, TU, TV> Create(IGraphDataLoader loader)
        {
            var calculator = new DistanceCalculator<T, TU, TV>(loader);

            return calculator;
        }

        /// <summary>
        /// Calculates the direct route.
        /// </summary>
        /// <param name="startNode">The start city.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">startNode must be in Rail Network.</exception>
        /// <exception cref="System.InvalidOperationException">NO SUCH ROUTE</exception>
        public double CalculateDirectRoute(string startNode, params string[] nodes)
        {
            if (Graph.Nodes.All(c => c.Key != startNode))
                throw new ArgumentException("startNode must be in IGraph.");

            if (nodes == null ||nodes.Length < 1)
                throw new ArgumentException("nodes must contain at least 1 valid INode in the IGraph.");


            double total = 0;
            var s = startNode;

            foreach (var c in nodes)
            {
                var route = Graph.Nodes[s].Edges.FirstOrDefault(er => er.ConnectedNode.NodeName == c);
                if (route == null)
                {
                    throw new InvalidOperationException("NO SUCH ROUTE");
                }

                total += route.Distance;
                s = c;
            }

            return total;

        }

        #region Recursive Path Walking. Here be Dragons!!!

        #region Exact Node Count

        /// <summary>
        /// Finds all paths with explicit node count.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <returns></returns>
        public int FindAllPathsWithExactNodeCount(string startNode, string endNode, int nodeCount)
        {
            INode<TU, TV> node = Graph.Nodes[startNode];

            var tracker = 0;

            //Go to each of target nodes, and recurse.
            foreach(var edge in node.Edges)
            {
                RecursiveExactNodeCount(edge.ConnectedNode, nodeCount, endNode, 1, ref tracker);
            }

            return tracker;
        }

        /// <summary>
        /// Recursives the exact node count.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="currentLevel">The current level.</param>
        /// <param name="tracker">The tracker.</param>
        private void RecursiveExactNodeCount(INode<TU, TV> node, int nodeCount, string endNode, int currentLevel, ref int tracker)
        {
            //If you hit the exact node count... stop
            if(nodeCount == currentLevel)
            {
                //if  you finish on the node you're looking for, bump the tracker count
                if (node.NodeName == endNode)
                {
                    tracker++;
                }
            }
            else
            {
                //Otherwise, recurse another level deeper and bump the current level.
                foreach(var edge in node.Edges)
                {
                    RecursiveExactNodeCount(edge.ConnectedNode, nodeCount, endNode, currentLevel + 1, ref tracker);
                }
            }
        }

        #endregion Explict Node Count

        #region Max Node Count

        /// <summary>
        /// Finds all paths with maximum node count.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <returns></returns>
        public int FindAllPathsWithMaximumNodeCount(string startNode, string endNode, int nodeCount)
        {
            INode<TU, TV> node = Graph.Nodes[startNode];

            var tracker = 0;

            //Go to each of target nodes, and recurse.
            foreach (var edge in node.Edges)
            {
                RecursiveMaxNodeCount(edge.ConnectedNode, nodeCount, endNode, 1, ref tracker);
            }

            return tracker;
        }

        /// <summary>
        /// Recursives the max node count.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="currentLevel">The current level.</param>
        /// <param name="tracker">The tracker.</param>
        private void RecursiveMaxNodeCount(INode<TU, TV> node, int nodeCount, string endNode, int currentLevel, ref int tracker)
        {
            //If you go past the max node count... stop
            if (currentLevel > nodeCount) return;

            //otherswise if the node is the one you're looking for, bump the tracker count
            if (node.NodeName == endNode)
            {
                tracker++;
            }

            //If you've gotten this far, walk deeper and find more valid routes
            foreach (var edge in node.Edges)
            {
                RecursiveMaxNodeCount(edge.ConnectedNode, nodeCount, endNode, currentLevel + 1, ref tracker);
            }
        }

        #endregion Max Node Count

        #region Max Distance
        
        /// <summary>
        /// Finds all paths with maximum distance.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="maximumDistance">The maximum distance.</param>
        /// <returns></returns>
        public int FindAllPathsWithMaximumDistance(string startNode, string endNode, double maximumDistance)
        {
            INode<TU, TV> node = Graph.Nodes[startNode];

            var tracker = 0;

            //Go to each of target nodes, and recurse.
            foreach (var edge in node.Edges)
            {
                RecursiveMaxDistance(edge.ConnectedNode, maximumDistance, endNode, edge.Distance, ref tracker);
            }

            return tracker;
        }

        /// <summary>
        /// Recursives the max distance.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="maxDistance">The max distance.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="currentDistance">The current distance.</param>
        /// <param name="tracker">The tracker.</param>
        private void RecursiveMaxDistance(INode<TU, TV> node, double maxDistance, string endNode, double currentDistance, ref int tracker)
        {
            //If you go past the max distance... stop
            if (currentDistance >= maxDistance) return;

            //otherswise if the node is the one you're looking for, bump the tracker count
            if (node.NodeName == endNode)
            {
                tracker++;
            }

            //If you've gotten this far, walk deeper and find more valid routes
            foreach (var edge in node.Edges)
            {
                RecursiveMaxDistance(edge.ConnectedNode, maxDistance, endNode, currentDistance + edge.Distance, ref tracker);
            }
        }

        #endregion

        #endregion Recursive Path Walking. Here be Dragons!!!

        /// <summary>
        /// Calculates the shortest route back to self.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <returns>The distance</returns>
        /// <exception cref="System.ArgumentException">startNode must be in IGraph.</exception>
        public double CalculateShortestRouteBackToSelf(string startNode)
        {
            if (Graph.Nodes.All(c => c.Key != startNode))
                throw new ArgumentException("startNode must be in IGraph.");

            var total = double.PositiveInfinity;

            IList<TU> bestRoute = null;
            
            foreach (var edge in Graph.Nodes[startNode].Edges)
            {
                Graph.Reset();
                Graph.Nodes[edge.ConnectedNode.NodeName].DistanceFromStart = 0;
                PopulateDistances();

                var distance = edge.Distance + Graph.Nodes[startNode].DistanceFromStart;

                if (distance < total)
                {
                    total = distance;
                    bestRoute = Graph.Nodes[startNode].ShortestPath;
                    bestRoute.Insert(0, Graph.Nodes[startNode]);
                }
            }

            Debug.WriteLine(bestRoute.PrintEdgePath<TU,TV>());
            return total;
        }

        /// <summary>
        /// Calculates the shortest route.
        /// </summary>
        /// <param name="startNode">The start city.</param>
        /// <param name="endNode">The end city.</param>
        /// <returns>
        /// The distance
        /// </returns>
        /// <exception cref="System.ArgumentException">startNode must be in IGraph.</exception>
        public double CalculateShortestRoute(string startNode, string endNode)
        {
            if (Graph.Nodes.All(c => c.Key != startNode))
                throw new ArgumentException("startNode must be in IGraph.");

            if (Graph.Nodes.All(c => c.Key != endNode))
                throw new ArgumentException("endNode must be in IGraph.");
            
            double total = 0;

            Graph.Reset();
            Graph.Nodes[startNode].DistanceFromStart = 0;
            PopulateDistances();
            total += Graph.Nodes[endNode].DistanceFromStart;


            Debug.WriteLine(Graph.Nodes[endNode].ShortestPath.PrintEdgePath<TU,TV>());

            if(double.IsPositiveInfinity(total))
            {
                throw new InvalidOperationException("NO SUCH ROUTE");
            }

            return total;

        }

        /// <summary>
        /// Populates the distances.
        /// </summary>
        private void PopulateDistances()
        {
            var done = false;
            
            var nodesToProcess = Graph.Nodes.Values.ToList();

            while (!done)
            {
                var nextNode = nodesToProcess
                    .OrderBy(c => c.DistanceFromStart)
                    .FirstOrDefault(n => !double.IsPositiveInfinity(n.DistanceFromStart));

                if (nextNode != null)
                {
                    Debug.WriteLine("Populate Distances: Next City: {0}", nextNode);
                
                    ProcessNode(nextNode, nodesToProcess);
                    nodesToProcess.Remove(nextNode);
                }
                else
                {
                    Debug.WriteLine("Populate Distances: Done");
                
                    done = true;
                }
            }
        }

        /// <summary>
        /// Processes the node.
        /// </summary>
        /// <param name="nextNode">The next city.</param>
        /// <param name="nodesToProcess">The nodes to process.</param>
        private void ProcessNode(INode<TU,TV> nextNode, IList<TU> nodesToProcess)
        {
            var edges = nextNode.Edges.Where(c => nodesToProcess.Contains(c.ConnectedNode));
            Debug.WriteLine("\tProcessNode: Edges: {0}", edges.Count());

            foreach (var edge in edges)
            {
                var distance = nextNode.DistanceFromStart + edge.Distance;
                Debug.WriteLine("\t\tProcessNode: Edge: {0} to {1}", edge.Distance, edge.ConnectedNode);

                if (distance < edge.ConnectedNode.DistanceFromStart)
                {
                    Debug.WriteLine("\t\t\tProcessNode: ConnectedNode DFS. Was:{0} Now:{1}", edge.ConnectedNode.DistanceFromStart, distance);

                    edge.ConnectedNode.DistanceFromStart = distance;

                    edge.ConnectedNode.ShortestPath = nextNode.ShortestPath.ToList();
                    edge.ConnectedNode.ShortestPath.Add(edge.ConnectedNode);
                }
            }
        }
    }
  
}
