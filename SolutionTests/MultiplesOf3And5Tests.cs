using Solutions;

namespace SolutionTests;

[TestFixture]
public class MultiplesOf3And5Tests
{
  [Test]
  public void SampleTests()
  {
    Assertion(expected : 23, input : 10);
    Assertion(expected : 78, input : 20);
    Assertion(expected : 9168, input : 200);
    Assertion(expected : 0, input : 0);
  }
  
  private static void Assertion(int expected, int input) =>
    Assert.AreEqual(
      expected,
      MultiplesOf3Or5.Solution(input),
      $"Value: {input}"
    );
}