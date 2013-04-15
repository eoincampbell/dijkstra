using System.Collections.Generic;

namespace Dijkstra.Core
{
    /// <summary>
    /// An interface representing a specific node within a Dijkstra IGraph
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU">The type of the U.</typeparam>
    public interface INode<T, TU>
        where T : class,INode<T, TU>
        where TU : class,IEdge<T, TU>
    {
        /// <summary>
        /// Gets the name of the node.
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        string NodeName { get; }

        /// <summary>
        /// Gets or sets the distance from start.
        /// </summary>
        /// <value>
        /// The distance from start.
        /// </value>
        double DistanceFromStart { get; set; }

        /// <summary>
        /// Gets or sets the shortest path.
        /// </summary>
        /// <value>
        /// The shortest path.
        /// </value>
        IList<T> ShortestPath { get; set; }

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <value>
        /// The edges.
        /// </value>
        ISet<TU> Edges { get; }

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        void AddEdge(TU edge);
    }
}