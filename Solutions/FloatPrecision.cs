namespace Solutions;

/* https://www.codewars.com/kata/5143d157ceb46d6a61000001
 * Update the solution method to round the argument value to the closest precision of two. The argument will always be a float.
 * 
 * 23.23456 --> 23.23
 * 1.546    --> 1.55
 * 
 */

public class FloatPrecision
{
  public static double RoundMath(double n)
  {
    return Math.Round(n, 2);
  }

  /* Benchmark results for 1000 iterations:
   * | Method    | Mean       | Error    | StdDev   |
   * |---------- |-----------:|---------:|---------:|
   * | RoundMath | 4,419.7 ns | 64.68 ns | 57.34 ns |
   * | RoundCast |   237.9 ns |  3.21 ns |  2.68 ns |
   */
  public static double RoundCast(double n)
  {
    return (int)((n + 0.005) * 100) / 100D;
  }
}