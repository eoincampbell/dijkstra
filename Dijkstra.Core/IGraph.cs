using System.Collections.Generic;

namespace Dijkstra.Core
{
    /// <summary>
    /// Interface for a node graph represent a sequence of traversable nodes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU">The type of the U.</typeparam>
    public interface IGraph<T,TU> where T : class,INode<T,TU> where TU : class,IEdge<T,TU>
    {
        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <value>
        /// The nodes.
        /// </value>
        Dictionary<string, T> Nodes { get; }

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="nodeName">Name of the node.</param>
        void AddNode(string nodeName);

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="startNodeName">Start name of the node.</param>
        /// <param name="endNodeName">End name of the node.</param>
        /// <param name="distance">The distance.</param>
        void AddEdge(string startNodeName, string endNodeName, double distance);

        /// <summary>
        /// Resets this instance.
        /// </summary>
        void Reset();
    }
}