using System.Text;

namespace Solutions;

public class CreatePhoneNumberKata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    /* StringBuilder is preferred for concatenating strings,
     * converting int to UTF-8 char is faster */
    StringBuilder sb = new StringBuilder("(000) 000-0000");

    for (int i = 0; i < numbers.Length; i++)
    {
      if (i < 3) sb[i + 1] = (char)(numbers[i] + 0x30);
      else if (i < 6) sb[i + 3] = (char)(numbers[i] + 0x30);
      else sb[i + 4] = (char)(numbers[i] + 0x30);
    }

    return sb.ToString();
  }

  public static string CreatePhoneNumberWithCharArray(int[] numbers)
  {
    char[] r = new char[14];
    r[0] = '(';
    r[1] = (char)(numbers[0] + 0x30);
    r[2] = (char)(numbers[1] + 0x30);
    r[3] = (char)(numbers[2] + 0x30);
    r[4] = ')';
    r[5] = ' ';
    r[6] = (char)(numbers[3] + 0x30);
    r[7] = (char)(numbers[4] + 0x30);
    r[8] = (char)(numbers[5] + 0x30);
    r[9] = '-';
    r[10] = (char)(numbers[6] + 0x30);
    r[11] = (char)(numbers[7] + 0x30);
    r[12] = (char)(numbers[8] + 0x30);
    r[13] = (char)(numbers[9] + 0x30);

    return new string(r);
  }
}