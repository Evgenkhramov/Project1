using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class InputOutput
    {
        public int IntInput(int min, int max)
        {
            int validNumber = 0;
            int allGood = 0;
            do
            {
                try
                {
                    int inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber >= min && inputNumber <= max)
                    {
                        allGood = 1;
                        validNumber = inputNumber;
                    }
                    else
                    {
                        allGood = 0;
                        Console.WriteLine("Please, min = {0} and max = {1}, enter a valid number ", min, max);
                    }
                }
                catch
                {
                    Console.WriteLine("It is not a number, enter a valid number");
                    allGood = 0;
                }
            }
            while (allGood == 0);
            return validNumber;
        }
        public void FinishGameOutput()
        {
            Console.WriteLine();
        }
    }
}
