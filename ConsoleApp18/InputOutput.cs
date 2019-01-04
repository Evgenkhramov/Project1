using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class InputOutput
    {
        public int IntInpunt(int min, int max)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, min = {0} and max = {1}, enter a valid number ", min, max);
            if (inputNumber >= min && inputNumber <= max)
            {
                return inputNumber;
            }
            else
            {
                Console.WriteLine("Please, min = {0} and max = {1}, enter a valid number ", min, max);
                return 0;
            }

             
        }
    }
}
