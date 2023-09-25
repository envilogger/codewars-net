namespace Solutions;

/* https://www.codewars.com/kata/54da5a58ea159efa38000836
 
   Given an array of integers, find the one that appears an odd number of times.
   
   There will always be only one integer that appears an odd number of times.
   
   Examples
   [7] should return 7, because it occurs 1 time (which is odd).
   [0] should return 0, because it occurs 1 time (which is odd).
   [1,1,2] should return 2, because it occurs 1 time (which is odd).
   [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
   [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
 */

public class FindTheOddInt
{
  /*
      Benchmark results:
      | Method       | Mean      | Error    | StdDev   |
     |------------- |----------:|---------:|---------:|
     | Solution     |  14.62 ns | 0.241 ns | 0.226 ns |
     | SolutionLinq | 119.51 ns | 1.175 ns | 1.042 ns |
   */
  
  public static int Solution(int[] seq) 
  {
    /*
     * Due to the fact, that XOR is commutative and associative,
     * which means a^a = 0, and a^a^b = a^b^a = b^a^a = b^0 = b,
     * we can use XOR to find the result.
     */
    int result = 0;
    foreach (int num in seq)
    {
      result ^= num;
    }
    return result;
  }

  public static int SolutionLinq(int[] seq)
  {
    return seq.Aggregate(0, (a, b) => a ^ b);
  }
  
}