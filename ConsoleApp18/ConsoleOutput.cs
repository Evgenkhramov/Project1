using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;
using BlackJackProject.Enums;
using BlackJackProject.Models;

namespace BlackJackProject
{
    public interface IOutput
    {
        void ShowFinishResult(List<Gamer> gamerList);
        void ShowResult(string number, string suit, int points);
        void ShowSomeOutput(string text);
        void ShowSomeOutput(string text, int number);
        void ShowSomeOutput(string text, int number1, int number2);    
        void ShowSomeOutput(Enums.GamerStatus text);
    }
    public interface IPrint
    {
        void PrintHistory(List<CardHistory> history);
    }

    public class PrintOutput : IPrint
    {
        public void PrintHistory(List<CardHistory> history)
        {
            foreach (CardHistory element in history)
            {
                Console.WriteLine($"Name: {element.GamerName} have: {element.GamerPoints} Points  and card: { element.CardOfRound.CardNumber} {element.CardOfRound.CardSuit}");
            }
        }
    }

    public class ConsoleOutput : IOutput
    {
        

        public void ShowFinishResult(List<Gamer> gamerList)
        {
            foreach (Gamer player in gamerList)
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

        public void ShowSomeOutput(string text, int number1, int number2)
        {
            Console.WriteLine(text, number1, number2);
        }

        public void ShowSomeOutput(Enums.GamerStatus text)
        {
            Console.WriteLine(text);
        }
    }
   

}
