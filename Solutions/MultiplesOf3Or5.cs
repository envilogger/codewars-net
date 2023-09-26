namespace Solutions;

/*
 * https://www.codewars.com/kata/514b92a657cdc65150000006
 *
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
 * The sum of these multiples is 23.
 * Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
 * 
 * Additionally, if the number is negative, return 0.
 * 
 * Note: If the number is a multiple of both 3 and 5, only count it once.
 */

public class MultiplesOf3Or5
{
  public static int Solution(int value)
  {
    if (value <= 0) return 0;
    // we only getting multiples up to value (excluding),
    int n = value - 1;
    // number of multiples of 3 is always (int)(value / 3) * 3
    var threes = n / 3;
    // number of multiples of 5 is always (int)(value / 5) * 5
    var fives = n / 5;
    // number of multiples of 15 should be counted once
    var fifteens = n / 15;

    return (threes * (3 + 3 * threes) +
            fives * (5 + 5 * fives) -
            fifteens * (15 + 15 * fifteens)) / 2;
  }
}