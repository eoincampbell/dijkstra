using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Dijkstra.Core;

namespace Dijkstra.Implementation
{
    /// <summary>
    /// Data Loader for the Rail Network Graph Implementation which expects input to be provide as a CSV
    /// </summary>
    public class RailNetworkDataLoader : IGraphDataLoader
    {
        /// <summary>
        /// The input argument exception message
        /// </summary>
        public const string InputArgumentExceptionMessage =
@"Input should be a csv string of length 3 alpha numeric codes representing. 
The first & second characters should be single letters representing the city name. 
The last character should be a single integer representing the distance. 
Error: ""{0}""";

        /// <summary>
        /// The valid city pair regex - used for verifying the input format of each city pair.
        /// </summary>
        public const string ValidCityPairRegex = "^[A-Z][A-Z][0-9]$";

        /// <summary>
        /// The raw input data
        /// </summary>
        private readonly string _rawData;

        /// <summary>
        /// Initializes a new instance of the <see cref="RailNetworkDataLoader" /> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public RailNetworkDataLoader(string input)
        {
            //Format should be AB1,BC2 and so on.
            var citypairs = input.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
            var regexValidator = new Regex(ValidCityPairRegex);

            foreach (var citypair in citypairs)
            {
                if (!regexValidator.Match(citypair).Success)
                    throw new ArgumentException(string.Format(InputArgumentExceptionMessage, citypair));

                int distance;

                if (!(int.TryParse(citypair[2].ToString(), out distance) && distance > 0))
                    throw new ArgumentException(string.Format(InputArgumentExceptionMessage, citypair));
            }

            _rawData = input;
        }



        /// <summary>
        /// Gets the nodes.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> IGraphDataLoader.GetNodes()
        {
            foreach (
                var citypair in _rawData.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim())
                )
            {
                yield return citypair[0].ToString();
                yield return citypair[1].ToString();
            }
        }

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Tuple<string,string,double>> IGraphDataLoader.GetEdges()
        {
            return _rawData
                .Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Select(cityPair =>
                        new Tuple<string, string, double>(
                            cityPair[0].ToString(),
                            cityPair[1].ToString(),
                            int.Parse(cityPair[2].ToString())
                            )
                );
        }
    }
}