#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ConsoleApplication2
{
  class Program
  {
    delegate double DoubleOp(double x);

    static void Main(string[] args)
    {
      DoubleOp multByTwo = delegate(double val) {return val * 2;};
      DoubleOp square = delegate(double val) { return val * val; };

      DoubleOp [] operations = {multByTwo, square};

      for (int i=0 ; i<operations.Length ; i++)
      {
        Console.WriteLine("Using operations[{0}]:", i);
        ProcessAndDisplayNumber(operations[i], 2.0);
        ProcessAndDisplayNumber(operations[i], 7.94);
        ProcessAndDisplayNumber(operations[i], 1.414);
        Console.WriteLine();
      }

    }

    static void ProcessAndDisplayNumber(DoubleOp action, double value)
    {
      double result = action(value);
      Console.WriteLine(
         "Value is {0}, result of operation is {1}", value, result);
    }

  }
}
