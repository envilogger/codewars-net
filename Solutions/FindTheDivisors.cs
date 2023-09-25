using System.Buffers;

namespace Solutions;

public class FindTheDivisors
{
  public static int[]? Divisors(int n)
  {
    int c = (int)Math.Sqrt(n);
    Queue<int> left = new Queue<int>(c);
    Stack<int> right = new Stack<int>(c);

    for(int i = 2; i <= c; i++)
    {
      if (n % i == 0)
      {
        left.Enqueue(i);
        int x = n / i;
        if (x == i) break; // found the center
        right.Push(x);
      }
    }
    
    if(left.Count == 0 && right.Count == 0) return null;

    int[] result = new int[left.Count + right.Count];
    left.CopyTo(result, 0);
    right.CopyTo(result, left.Count);

    return result;
  }
  
  public static int[]? Divisors2(int n)
  {
    var c = (int)Math.Ceiling(Math.Sqrt(n));
    var first = new int[c];
    var second = new int[c];
    int p1 = 0;
    int p2 = c - 1;
    for (int i = 2; i <= c; i++)
    {
      if (n % i == 0)
      {
        first[p1] = i;
        p1++;

        int x = n / i;
        if (x == i) continue;
        
        second[p2] = x;
        p2--;
      }
    }

    if (p1 == 0 && p2 == c - 1) return null;

    int[]? result = new int[p1 + c - p2 - 1];
    for (int i = 0; i < p1; i++)
    {
      result[i] = first[i];
    }

    for (int i = 0; i < c - 1 - p2; i++)
    {
      result[i + p1] = second[p2 + i + 1];
    }

    return result;
  }
}