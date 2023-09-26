using BenchmarkDotNet.Attributes;

namespace Solutions;

public class FloatPrecisionBenchmark
{
  [Benchmark]
  public void RoundMath()
  {
    for (int i = 0; i < 1000; i++)
    {
      FloatPrecision.RoundMath(1.234612641646);
    }
  }

  [Benchmark]
  public void RoundCast()
  {
    for (int i = 0; i < 1000; i++)
    {
      FloatPrecision.RoundCast(1.234612641646);
    }
  }
}