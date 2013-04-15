using System;
using System.Collections.Generic;

namespace Dijkstra.Core
{
    /// <summary>
    /// A interface for a data loader for a specific set of graph data 
    /// representing nodes & edges in a graph network
    /// </summary>
    public interface IGraphDataLoader
    {
        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetNodes();

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Tuple<string, string, double>> GetEdges();
    }
}
