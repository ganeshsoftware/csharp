using System;
using System.Text;

public class Example
{
   public static void Main()
   {
      StringBuilder sb = new StringBuilder();
      
	  bool flag = true;
	  
      string[] spellings = { "recieve", "receeve", "receive" };
      
	  sb.AppendFormat("Which of the following spellings is {0}:", flag);
	  
      sb.AppendLine();
      
	  for (int ctr = 0; ctr <= spellings.GetUpperBound(0); ctr++) 
	  {
         sb.AppendFormat("  {0}. {1}", ctr, spellings[ctr]);
         //sb.AppendLine();
      }
      sb.AppendLine();
      Console.WriteLine(sb.ToString());
   }
}