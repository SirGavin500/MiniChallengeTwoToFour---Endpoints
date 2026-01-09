using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_template.Services;

public class CompareNumbersService
{
    public string Compare(int num1, int num2)
    {
        if (num1 > num2)
        {
            return "The first number is greater than the second number. " +
                   "The second number is less than the first number.";
        }
        else if (num1 < num2)
        {
            return "The first number is less than the second number. " +
                   "The second number is greater than the first number.";
        }
        else
        {
            return "The first number is equal to the second number. " +
                   "The second number is equal to the first number.";
        }
    }
}
