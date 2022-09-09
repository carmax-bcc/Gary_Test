using MPGTest;

using Xunit;

namespace MPG_Test.Tests
{
  public class MPGCalc_Tests
  {
    [Fact]
    public void GetAverageMpgTest()
    {
      List<Vehicle> vehicles = new()
      {
                new Vehicle { Make = "Honda", MPG = 34 },
                new Vehicle { Make = "Honda", MPG = 20 },
                new Vehicle { Make = "Honda", MPG = 22 },
                new Vehicle { Make = "Ford", MPG = 17 },
                new Vehicle { Make = "Ford", MPG = 14 },
                new Vehicle { Make = "Lexus", MPG = 27 }
            };
      List<Vehicle> emptyVehicles = new();

      Assert.Equal(25.33, MPGCalc.GetAverageMpg(vehicles, "Honda").Value, 2);
      Assert.Equal(25.33, MPGCalc.GetAverageMpg(vehicles, "honda").Value, 2);
      Assert.Equal(27, MPGCalc.GetAverageMpg(vehicles, "Lexus").Value, 2);
      Assert.Null(MPGCalc.GetAverageMpg(null, "Honda"));
      Assert.Null(MPGCalc.GetAverageMpg(emptyVehicles, "Honda"));
      Assert.Null(MPGCalc.GetAverageMpg(vehicles, "Ferrari"));
      Assert.Null(MPGCalc.GetAverageMpg(vehicles, string.Empty));
      Assert.Null(MPGCalc.GetAverageMpg(vehicles, null));
    }
  }
}