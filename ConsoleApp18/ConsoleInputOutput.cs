using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class ConsoleInputOutput
    {
        public string StringInput()
        {
            return Console.ReadLine();
        }

        public int InputInt(int min, int max)
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
                        Console.WriteLine(TextCuts.TextCuts.EnterValidNumber,min,max);
                    }
                }
                catch
                {
                    Console.WriteLine(TextCuts.TextCuts.NotValidNumber);
                    allGood = 0;
                }
            }
            while (allGood == 0);

            return validNumber;
        }

        public void ShowFinishResult(Gamer[] GamerArr)
        {
            for (int i = 0; i < GamerArr.Length; i++)
            {
                Console.WriteLine(TextCuts.TextCuts.ShowFinishResultByConsole,
                    GamerArr[i].GamerName, GamerArr[i].GamerPoints, GamerArr[i].GamerStatus, GamerArr[i].GamerWinCash);
            }
        }

        public void ShowResult(string Number, string Suit, int Points)
        {

            Console.WriteLine(TextCuts.TextCuts.ShowResultByConsole, Number, Suit, Points);
        }

        public void ShowSomeOutput(string text)
        {
            Console.WriteLine(TextCuts.TextCuts.ShowSomeText, text);
        }

        public void ShowSomeOutput(string text, int number )
        {
             
            Console.WriteLine(text, number);
        }

        public void ShowSomeOutput(string text, int number1, int number2)
        {
             
            Console.WriteLine(text, number1,number2);
        }
    }
}
