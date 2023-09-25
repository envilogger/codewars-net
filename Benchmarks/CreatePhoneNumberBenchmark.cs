using BenchmarkDotNet.Attributes;

namespace Solutions;

public class CreatePhoneNumberBenchmark
{
  public int[] arrays = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
  
  [Benchmark]
  public string UsingStringBuilder()
  {
    return CreatePhoneNumberKata.CreatePhoneNumber(arrays);
  } 
  
  [Benchmark]
  public string UsingCharArray()
  {
    return CreatePhoneNumberKata.CreatePhoneNumberWithCharArray(arrays);
  }
}