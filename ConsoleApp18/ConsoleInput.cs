using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class ConsoleInput
    {
        public string InputString()
        {
            return Console.ReadLine();
        }

        public int InputInt(int min, int max)
        {
            int validNumber = 0;
            bool allGood = true ;
            while (allGood) 
            {
                try
                {
                    int inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber >= min && inputNumber <= max)
                    {
                        allGood = false;
                        validNumber = inputNumber;
                    }
                    else
                    {
                        allGood = true;
                        Console.WriteLine(TextCuts.EnterValidNumber, min, max);
                    }
                }
                catch
                {
                    Console.WriteLine(TextCuts.NotValidNumber);
                    allGood = true;
                }
            }

            return validNumber;
        }
    }
}
