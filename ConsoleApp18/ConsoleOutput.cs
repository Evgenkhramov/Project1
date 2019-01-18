using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    public class ConsoleOutput
    {

        public void ShowFinishResult(List<Gamer> GamerList)
        {
            foreach(Gamer player in GamerList)
            {
                Console.WriteLine(TextCuts.ShowFinishResultByConsole,
                    player.Name, player.Points, player.Status, player.WinCash);
            }
        }

        public void ShowResult(string number, string suit, int points)
        {
            Console.WriteLine(TextCuts.ShowResultByConsole, number, suit, points);
        }

        public void ShowSomeOutput(string text)
        {
            Console.WriteLine(TextCuts.ShowSomeText, text);
        }

        public void ShowSomeOutput(string text, int number)
        {
            Console.WriteLine(text, number);
        }
        public void ShowSomeOutput(Enums.GamerStatus text)
        {
            Console.WriteLine(text);
        }

        public void ShowSomeOutput(string text, int number1, int number2)
        {
            Console.WriteLine(text, number1, number2);
        }
    }
}
