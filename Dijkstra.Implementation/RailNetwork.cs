using System;
using System.Collections.Generic;
using System.Linq;
using Dijkstra.Core;

namespace Dijkstra.Implementation
{
    public class RailNetwork : IGraph<City, Route>
    {
        /// <summary>
        /// Gets the cities.
        /// </summary>
        /// <value>
        /// The cities.
        /// </value>
        public Dictionary<string, City> Nodes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RailNetwork" /> class.
        /// </summary>
        public RailNetwork()
        {
            Nodes = new Dictionary<string, City>();
        }

        /// <summary>
        /// Adds the city stop.
        /// </summary>
        /// <param name="node">The node.</param>
        public void AddNode(string nodeName)
        {
            if(!Nodes.ContainsKey(nodeName))
                Nodes.Add(nodeName, new City(nodeName)); 
        }

        /// <summary>
        /// Adds the route.
        /// </summary>
        /// <param name="startNodeName">Start name of the node.</param>
        /// <param name="endNodeName">End name of the node.</param>
        /// <param name="distance">The distance.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public void AddEdge(string startNodeName, string endNodeName, double distance)
        {
            if (!Nodes.ContainsKey(startNodeName))
                throw new ArgumentOutOfRangeException(string.Format("startNodeName:{0}", startNodeName));

            if (!Nodes.ContainsKey(endNodeName))
                throw new ArgumentOutOfRangeException(string.Format("endNodeName:{0}", endNodeName));

            var r = new Route(Nodes[endNodeName], distance);

            Nodes[startNodeName].AddEdge(r);
        }

        /// <summary>
        /// Gets the city count.
        /// </summary>
        /// <value>
        /// The city count.
        /// </value>
        public int NodeCount
        {
            get { return Nodes.Count; }
        }

        /// <summary>
        /// Gets the distinct route count.
        /// </summary>
        /// <value>
        /// The distinct route count.
        /// </value>
        public int EdgeCount
        {
            get { return Nodes.SelectMany(c => c.Value.Edges).Distinct().Count();  }
        }

        /// <summary>
        /// Resets the distances for each value in this instance.
        /// </summary>
        public void Reset()
        {
            foreach (var city in Nodes)
            {
                city.Value.DistanceFromStart = double.PositiveInfinity;
                city.Value.ShortestPath = new List<City>(){city.Value};
            }
        }

    }
}
