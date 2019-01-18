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

        public int InputInt( int min, int max)
        {
            var intCheck = new IntCheck();
            int validNumber = intCheck.CheckNumber( min, max);
            return validNumber;
        }    
    }
}
