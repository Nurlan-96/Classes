﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Models
{
    internal class Calculator
    {
        public int Value1 { get; set; }
        public char Symbol { get; set; }
        public int Value2 { get; set; }


        public Calculator(int value1, char symbol, int value2)
        {
            Value1 = value1;
            Symbol = symbol;
            Value2 = value2;
        }
        public int Calculate ()
        {int result = 0;
            switch (Symbol)
            {
                case '+':
                    result = Value1 + Value2;
                break;
                case '-':
                result = Value1 - Value2;
                break;
                case '*':
                result = Value1 * Value2;
                break;
                case '/':
                    if (Value2 != 0)
                    {
                        result = Value1 / Value2;
                    }
                    else Console.WriteLine("Can not divide by zero");
                    break;
                default:
                Console.WriteLine("only use '+,-,*,/'");
                break;
            }
          return result;
        }
    }
}


