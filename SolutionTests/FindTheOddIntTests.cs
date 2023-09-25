using Solutions;

namespace SolutionTests;

[TestFixture]
public class FindTheOddIntTests
{
  [Test]
  public void Tests()
  {
    Assert.AreEqual(5 , FindTheOddInt.Solution ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
  }
}