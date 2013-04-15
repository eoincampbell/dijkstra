using Dijkstra.Core;

namespace Dijkstra.Implementation
{
    public class Route : IEdge<City, Route>
    {
        /// <summary>
        /// Gets or sets the connected city.
        /// </summary>
        /// <value>
        /// The connected city.
        /// </value>
        public City ConnectedNode { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public double Distance { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        /// <param name="connectedCity">The connected city.</param>
        /// <param name="distance">The distance.</param>
        public Route(City connectedCity, double distance)
        {
            ConnectedNode = connectedCity;
            Distance = distance;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return 13*ConnectedNode.GetHashCode();
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
            if (!(obj is Route))
            {
                return false;
            }

            var o = obj as Route;

            return o.ConnectedNode.Equals(ConnectedNode);
        }
    }
}
