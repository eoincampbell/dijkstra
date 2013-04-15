using System.Collections.Generic;
using System.Linq;

namespace Dijkstra.Core
{
    /// <summary>
    /// Static class for Extension methods relating to dijkstra graphs
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Prints the edge path.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TU">The type of the U.</typeparam>
        /// <param name="nodes">The nodes.</param>
        /// <returns></returns>
        public static string PrintEdgePath<T,TU>(this IList<T> nodes)
            where T : class,INode<T, TU>
            where TU : class,IEdge<T, TU>
        {
            return string.Join("-", nodes.Select(n => n.NodeName));
        }
    }
}