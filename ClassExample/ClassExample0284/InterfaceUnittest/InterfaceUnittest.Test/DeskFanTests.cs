using ClassExample0284;

namespace InterfaceUnittest.Test {
    public class DeskFanTests {
        [Fact]
        public void PowerLowerThanZero_OK() {
            var powerSupply = new PowerSupplyLowerThanZero();
            var fan = new DeskFan(powerSupply);
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PowerHigherThan200_Warning() {
            var deskFan = new DeskFan(new PowerSupplyHigherThan200());
            var expect = "Warning!";
            var actual = deskFan.Work();
            Assert.Equal(expect, actual);
        }
    }

    class PowerSupplyLowerThanZero : IPowerSupply {
        public int GetPower() {
            return 0;
        }
    }

    class PowerSupplyHigherThan200 : IPowerSupply {
        public int GetPower() {
            return 210;
        }
    }
}