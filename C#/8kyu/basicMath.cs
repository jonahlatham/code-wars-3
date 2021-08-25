// https://www.codewars.com/kata/57356c55867b9b7a60000bd7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace Solution
{
    public static class Program
    {
        public static double basicOp(char o, double a, double b)
        {
            if (o == '+')
            {
                return a + b;
            }
            else if (o == '-')
            {
                return a - b;
            }
            else if (o == '*')
            {
                return a * b;
            }
            else
            {
                return a / b;
            }
        }
    }
}

// // Better Solutions
namespace Solution
{
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
      switch(op){
        case '+': return val1+val2;
        case '-': return val1-val2;
        case '*': return val1*val2;
        case '/': return val1/val2;
        default:
           throw new System.ArgumentException("Unknown operation!", op.ToString());
      }
    }
  }
}

// // &

public static class Program
{
  public static double basicOp(char op, double a, double b)
  {
    return Convert.ToDouble(new DataTable().Compute($"{a}{op}{b}", ""));
  }
}