namespace Dijkstra.Core
{
    /// <summary>
    /// Interface representing a path from an originator node and some 
    /// other node and the weighted path between them.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU">The type of the U.</typeparam>
    public interface IEdge<T, TU>
        where T : class,INode<T, TU>
        where TU : class,IEdge<T, TU>
    {
        /// <summary>
        /// Gets or sets the connected node.
        /// </summary>
        /// <value>
        /// The connected node.
        /// </value>
        T ConnectedNode { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        double Distance { get; set; }
    }
}