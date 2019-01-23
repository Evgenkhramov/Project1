using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;


namespace BlackJackProject
{
    interface IInput
    {
        string InputString();
        int InputInt(int min, int max);
    }

    public class ConsoleInput:IInput  
    {
        public string InputString()
        {
            return Console.ReadLine();
        }

        public int InputInt( int min, int max)
        {
            var intCheck = new NumberValidation();
            int validNumber = intCheck.CheckNumber( min, max);
            return validNumber;
        }   
        
    }
}
