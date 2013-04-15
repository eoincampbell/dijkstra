using System;
using System.Collections.Generic;
using Dijkstra.Core;

namespace Dijkstra.Implementation
{
    /// <summary>
    /// Class representing a Stop on the Rail Network
    /// </summary>
    public class City : INode<City, Route>
    {
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        /// <value>
        /// The name of the city.
        /// </value>
        public string NodeName { get; private set; }

        /// <summary>
        /// Gets or sets the distance from start.
        /// </summary>
        /// <value>
        /// The distance from start.
        /// </value>
        public double DistanceFromStart { get; set; }


        /// <summary>
        /// Gets or sets the shortest path.
        /// </summary>
        /// <value>
        /// The shortest path.
        /// </value>
        public IList<City> ShortestPath { get; set; } 

        /// <summary>
        /// Gets the routes.
        /// Hashset to prevent duplicates
        /// </summary>
        /// <value>
        /// The routes.
        /// </value>
        public ISet<Route> Edges { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="City" /> class.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        public City(string cityName)
        {
            NodeName = cityName;
            DistanceFromStart = double.PositiveInfinity;
            Edges = new HashSet<Route>();
            ShortestPath = new List<City>();
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return 13 * NodeName.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is City))
            {
                return false;
            }

            var o = obj as City;

            return o.NodeName == NodeName;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return NodeName;
        }

        /// <summary>
        /// Adds the route.
        /// </summary>
        /// <param name="route">The route.</param>
        /// <exception cref="System.ArgumentNullException">City 'otherCity' cannot be null</exception>
        /// <exception cref="System.ArgumentException">City cannot route to itself.</exception>
        public void AddEdge(Route route)
        {
            if (route == null)
                throw new ArgumentNullException("route");

            Edges.Add(route);
        }
    }
}
