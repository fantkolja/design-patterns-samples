using System.Text;

namespace DesignPatterns.Flyweight
{
  public static class MemorySizeConverter
  {
      public enum SizeUnit
      {
        Byte = 1,
        KB = 2,
        MB = 3,
        GB = 4,
        TB = 5,
      }

      private static int _factor = 1024;
      private static string _displayFormat = "0.00";

      private static SizeUnit _maxSizeUnit = Enum.GetValues(typeof(SizeUnit)).Cast<SizeUnit>().Max();

      private static string? _getSizeUnitName(SizeUnit unit)
      {
        return Enum.GetName(typeof(SizeUnit), unit);
      }

      public static string ToSize(this long value, SizeUnit unit)
      {
          return (value / (double)Math.Pow(_factor, (long)unit)).ToString(_displayFormat);
      }

      public static string ToSmallestFullSize(this long value)
      {
        double nextValue = value;
        SizeUnit currentSizeUnit = SizeUnit.Byte;
        while (nextValue > _factor && currentSizeUnit != _maxSizeUnit)
        {
          currentSizeUnit++;
          nextValue = nextValue / _factor;
        }
        return new StringBuilder(nextValue.ToString(_displayFormat))
          .Append($" {_getSizeUnitName(currentSizeUnit)}")
          .ToString();
      }
  }
}