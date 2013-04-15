using System.Collections.Generic;

namespace Dijkstra.Core
{
    /// <summary>
    /// Contract for an implementation of a DistanceCalculator over a Dijkstra Graph
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TU">The type of the U.</typeparam>
    /// <typeparam name="TV">The type of the V.</typeparam>
    public interface IDistanceCalculator<out T, TU, TV>
        where T : class,IGraph<TU, TV>
        where TU : class,INode<TU, TV>
        where TV : class,IEdge<TU, TV>
    {
        T Graph { get; }

        /// <summary>
        /// Calculates the shortest route.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <returns>The distace of the shortest edgePath</returns>
        double CalculateShortestRoute(string startNode, string endNode);

        /// <summary>
        /// Calculates the shortest route back to self.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <returns>the distance of the shortest edge path back to start node</returns>
        double CalculateShortestRouteBackToSelf(string startNode);

        /// <summary>
        /// Calculates the direct route.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="nodes">The nodes.</param>
        /// <returns>the distance over a specified sequence of explicitly list nodes</returns>
        double CalculateDirectRoute(string startNode, params string[] nodes);


        /// <summary>
        /// Finds all paths with explicit node count.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <returns>The number of paths</returns>
        int FindAllPathsWithExactNodeCount(string startNode, string endNode, int nodeCount);

        /// <summary>
        /// Finds all paths with explicit node count.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="nodeCount">The node count.</param>
        /// <returns>The number of paths</returns>
        int FindAllPathsWithMaximumNodeCount(string startNode, string endNode, int nodeCount);

        /// <summary>
        /// Finds all paths with maximum distance.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="endNode">The end node.</param>
        /// <param name="maximumDistance">The maximum distance.</param>
        /// <returns>The number of paths</returns>
        int FindAllPathsWithMaximumDistance(string startNode, string endNode, double maximumDistance);
    }
}