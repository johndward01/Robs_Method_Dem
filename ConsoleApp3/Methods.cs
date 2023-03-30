using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3;
internal class Methods
{
    public static bool Range(int start, int end, int numberToCheck)
    {
        if (numberToCheck >= start && numberToCheck <= end)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public static void MultiplicationTable(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
