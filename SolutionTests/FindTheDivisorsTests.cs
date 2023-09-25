using Solutions;

namespace SolutionTests;

public class FindTheDivisorsTests
{
  [Test]
  public void SampleTest()
  {
    Assert.AreEqual(new int[] {3, 5}, FindTheDivisors.Divisors(15));
    Assert.AreEqual(new int[] {2, 4, 8}, FindTheDivisors.Divisors(16));
    Assert.AreEqual(new int[] {11, 23}, FindTheDivisors.Divisors(253));
    Assert.AreEqual(new int[] {2, 3, 4, 6, 8, 12}, FindTheDivisors.Divisors(24));
  }
}