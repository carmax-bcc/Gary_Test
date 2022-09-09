// See https://aka.ms/new-console-template for more information

namespace MPGTest
{
  static class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello, World!");


      Console.WriteLine(MPGCalc.GetAverageMpg(new List<Vehicle>() { new Vehicle() { Make = "Yugo", MPG = 3 } }, "Yugo"));
    }
  }
}