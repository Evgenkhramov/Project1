using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    class ConsoleOutput
    {

        public void ShowFinishResult(Gamer[] GamerArr)
        {
            for (int i = 0; i < GamerArr.Length; i++)
            {
                Console.WriteLine(TextCuts.ShowFinishResultByConsole,
                    GamerArr[i].Name, GamerArr[i].Points, GamerArr[i].Status, GamerArr[i].WinCash);
            }
        }

        public void ShowResult(string Number, string Suit, int Points)
        {
            Console.WriteLine(TextCuts.ShowResultByConsole, Number, Suit, Points);
        }

        public void ShowSomeOutput(string text)
        {
            Console.WriteLine(TextCuts.ShowSomeText, text);
        }

        public void ShowSomeOutput(string text, int number)
        {
            Console.WriteLine(text, number);
        }

        public void ShowSomeOutput(string text, int number1, int number2)
        {
            Console.WriteLine(text, number1, number2);
        }
    }
}
