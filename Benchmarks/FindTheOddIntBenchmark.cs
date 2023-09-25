using BenchmarkDotNet.Attributes;

namespace Solutions;

public class FindTheOddIntBenchmark
{
  [Benchmark]
  public void Solution()
  {
    FindTheOddInt.Solution(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 });
  }
  
  [Benchmark]
  public void SolutionLinq()
  {
    FindTheOddInt.SolutionLinq(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 });
  }
}