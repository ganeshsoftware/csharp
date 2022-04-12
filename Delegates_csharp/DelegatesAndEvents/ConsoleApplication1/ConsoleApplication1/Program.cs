#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ConsoleApplication1
{
  class Program
  {
    delegate string delegateTest(string val);

    static void Main(string[] args)
    {
      string mid = ", middle part,";

      delegateTest d = delegate(string param)
      {
        param += mid;
        param += " and this was added to the string.";
        return param;
      };

      Console.WriteLine(d("Start of string"));

    }
  }
}
