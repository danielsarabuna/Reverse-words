using System;
using System.Text;

public class Program
{  
  public static string ReverseWords(string str)
  {
    string[] splStr = str.Split(" ");
    StringBuilder builder = new StringBuilder();
    foreach (string s in splStr)
    {
      char[] charArr = s.ToCharArray();
      for (int i = charArr.Length - 1; i >= 0; i--)
        builder.Append(charArr[i]);
        
      builder.Append(" ");
    }
    return builder.ToString().Trim();
  }
}