using System;
using Dijkstra.Core;
using Dijkstra.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dijkstra.Tests
{
    [TestClass]
    public class DjikstraTests
    {
        private IDistanceCalculator<RailNetwork, City, Route> _distanceCalculator;

        private IGraphDataLoader _loader;

        private const string Input = "AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7";

        [TestInitialize()]
        public void TestInitialize()
        {
            _loader = new RailNetworkDataLoader(Input);

            _distanceCalculator = DistanceCalculator<RailNetwork, City, Route>.Create(_loader);
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            _loader = null;
            _distanceCalculator = null;
        }

        #region Input Validation Tests

        [TestMethod]
        [TestCategory("Input Validation")]
        [ExpectedException(typeof(ArgumentException))]
        public void DijkstraInstantiation_InvalidData_ShouldThrowException()
        {
            _loader = new RailNetworkDataLoader("123,ABC");
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        [ExpectedException(typeof(ArgumentException))]
        public void DijkstraInstantiation_SingleInvalidCityData_ShouldThrowException()
        {
            _loader = new RailNetworkDataLoader("ABC9");
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        [ExpectedException(typeof(ArgumentException))]
        public void DijkstraInstantiation_MultipleInvalidCityData_ShouldThrowException()
        {
            _loader = new RailNetworkDataLoader("AB1,ABC9");
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        [ExpectedException(typeof(ArgumentException))]
        public void DijkstraInstantiation_InvalidDistanceData_ShouldThrowException()
        {
            _loader = new RailNetworkDataLoader("AB1,AC0");
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        public void DijkstraInstantiation_ValidCityData()
        {
            _loader = new RailNetworkDataLoader("AB5");
            _distanceCalculator = DistanceCalculator<RailNetwork, City, Route>.Create(_loader);

            Assert.AreEqual(2, _distanceCalculator.Graph.NodeCount);

            Assert.AreEqual(1, _distanceCalculator.Graph.EdgeCount);
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        public void DijkstraInstantiation_ValidCityDataWithRepeatingCities()
        {
            _loader = new RailNetworkDataLoader("AB5,BC6,CD7");
            _distanceCalculator = DistanceCalculator<RailNetwork, City, Route>.Create(_loader);

            Assert.AreEqual(4, _distanceCalculator.Graph.NodeCount);

            Assert.AreEqual(3, _distanceCalculator.Graph.EdgeCount);
        }

        [TestMethod]
        [TestCategory("Input Validation")]
        public void DijkstraInstantiation_ValidCityDataWithRepeatingRoutes()
        {
            _loader = new RailNetworkDataLoader("AB5,BC6,CD7,BC6,BC6");
            _distanceCalculator = DistanceCalculator<RailNetwork, City, Route>.Create(_loader);

            Assert.AreEqual(4, _distanceCalculator.Graph.NodeCount);

            Assert.AreEqual(3, _distanceCalculator.Graph.EdgeCount);
        }

        #endregion Input Validation Tests

        #region Shortest Distance Tests

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_SimplePath_Test1()
        {

            var distance = _distanceCalculator.CalculateDirectRoute("A", "B", "C");

            Assert.AreEqual(9, distance);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_SimplePath_Test2()
        {

            var distance = _distanceCalculator.CalculateDirectRoute("A", "D");

            Assert.AreEqual(5, distance);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_ViaPath_Test3()
        {

            var distance = _distanceCalculator.CalculateDirectRoute("A", "D", "C");

            Assert.AreEqual(13, distance);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_ViaPath_Test4()
        {

            var distance = _distanceCalculator.CalculateDirectRoute("A", "E", "B", "C", "D");

            Assert.AreEqual(22, distance);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DijkstraDistance_ViaPath_Test5()
        {

            var distance = _distanceCalculator.CalculateDirectRoute("A", "E", "D");
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_ShortestPath_Test8()
        {

            var distance = _distanceCalculator.CalculateShortestRoute("A", "C");

            Assert.AreEqual(9, distance);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_ShortestPath_Test9()
        {
            var distance = _distanceCalculator.CalculateShortestRouteBackToSelf("B");

            Assert.AreEqual(9, distance);
        }
        #endregion

        #region Path Finders 

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_MaxNodeCount_Test6()
        {
            var paths = _distanceCalculator.FindAllPathsWithMaximumNodeCount("C", "C", 3);

            Assert.AreEqual(2, paths);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_ExactNodeCount_Test7()
        {
            var paths = _distanceCalculator.FindAllPathsWithExactNodeCount("A", "C", 4);

            Assert.AreEqual(3, paths);
        }

        [TestMethod]
        [TestCategory("Distance Calculations")]
        public void DijkstraDistance_MaxDistance_Test10()
        {
            var paths = _distanceCalculator.FindAllPathsWithMaximumDistance("C", "C", 30);

            Assert.AreEqual(7, paths);
        }

        #endregion
    }
}
