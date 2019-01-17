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

        public void ShowFinishResult(List<Gamer> GamerList)
        {
            foreach(Gamer player in GamerList)
            {
                Console.WriteLine(TextCuts.ShowFinishResultByConsole,
                    player.Name, player.Points, player.Status, player.WinCash);
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
