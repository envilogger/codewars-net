namespace Solutions;

/* https://www.codewars.com/kata/559ce00b70041bc7b600013d
 
   I need to save some money to buy a gift. I think I can do something like that:
   
   First week (W0) I save nothing on Sunday, 1 on Monday, 2 on Tuesday... 6 on Saturday, second week (W1) 2 on Monday... 7 on Saturday and so on according to the table below where the days are numbered from 0 to 6.
   
   Can you tell me how much I will have for my gift on Saturday evening after I have saved 12? (Your function finance(6) should return 168 which is the sum of the savings in the table).
   
   Imagine now that we live on planet XY140Z-n where the days of the week are numbered from 0 to n (integer n > 0) and where I save from week number 0 to week number n included (in the table below n = 6).
   
   How much money would I have at the end of my financing plan on planet XY140Z-n?
   
   --	Su	Mo	Tu	We	Th	Fr	Sa
   W6							12   12
   W5						10	11   21
   W4					8	9	10   27
   W3				6	7	8	9    30
   W2			4	5	6	7	8    30
   W1		2	3	4	5	6	7    27 
   W0	0	1	2	3	4	5	6    21
      
      0  3  9  18 30 45 63
      
      0  1  3  6  10 15 21
   */


public class FinancingPlanOnPlanet
{
   /* Solution:
    *    Number of weeks and number of days in a week are equivalent.
    *    Knowing this fact we can rewrite the example above like so:
    *                      6  
    *                4  5  6  7  8
    *          2  3  4  5  6  7  8  9  10
    *    0  1  2  3  4  5  6  7  8  9  10  11  12
    *
    * The number n, is a mean for every row, and number of elements in each row
    * forms another arithmetic progression, where a1 is 1 or 3 (depending on n%2),
    * and d is 4
    *
    * Knowing mean of an arithmetic progression and number of elements, we can quickly calculate the sum:
    * Srow = Nrow * mean(a), since mean(a) is always n, Srow = Nrow * n,
    * where Nrow = number of elements in a row
    *
    * We can simply describe the calculation for example above like:
    * 6*1 + 6*5 + 6*9 + 6*13, or (n*1 + n*5 + n*9 + n*13) (for odd n, coefficients will be 3, 7, 11, 15, ...)
    *
    * In other words, the result will be: n * Sh, where Sh is a sum of arithmetic progression
    * of number of elements in each row from top to bottom.
    *
    * Sh = (h(a1 + ah)) / 2, where h is number of rows.
    * after all the simplifications, the formula can be represented as:
    *
    * S = n^3 + 3n^2 - x^2n + xn + 2n / 2,
    * where x = n % 2
    *
    * Another note, the division by 2 is placed in the end, to avoid rounding. Since 5/2 for ulong will be 2.
    *
    * Addition: since x = n%2, which is always 0 or 1, x^2 doesn't make sense and can be represented as x.
    * In this case, -x^2n+xn == -xn+xn == 0 and can be removed
    */
   public static ulong Solution(ulong n) => (n * n * n + 3 * n * n + 2 * n) / 2;
}