using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaAsistencias.BLO;
using SistemaAsistencias.Entities;

namespace SistemaAsistencias.Test
{
    [TestClass]
    public class PositionBLOTest
    {
        private readonly PositionBLO _positionBlo;

        public PositionBLOTest()
        {
            _positionBlo = new PositionBLO();
        }

        [TestMethod]
        public void Value_Is_Not_Decimal()
        {
            var value = "";
            var result = _positionBlo.IsDecimal(value);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void Value_Is_Decimal()
        {
            var value = "10.25";
            var result = _positionBlo.IsDecimal(value);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Position_Model_Is_Not_Valid()
        {
            Position p = new Position
            {
                Description = string.Empty,
                SalaryBasexHour = 0
            };

            var (isSuccess, message) = _positionBlo.IsValid(model: p);
            Assert.AreEqual(isSuccess, false);
            Assert.IsTrue(message != string.Empty);
        }

        [TestMethod]
        public void Position_Model_Is_Valid()
        {
            Position p = new Position
            {
                Description = "DIGITADOR",
                SalaryBasexHour = 10.50m
            };

            var (isSuccess, message) = _positionBlo.IsValid(model: p);
            Assert.AreEqual(isSuccess, true);
            Assert.IsTrue(message == string.Empty);
        }
    }
}
