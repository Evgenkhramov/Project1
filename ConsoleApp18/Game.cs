using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Game
    {
        public Game()
        {
            int maxRate = 50;
            int maxBot = 6;
            InputOutput inputOutput = new InputOutput();

            inputOutput.ShowSomeOutput("Game Start!");
            inputOutput.ShowSomeOutput("Enter your name please:");
            string UserName = inputOutput.StringInput();
            inputOutput.ShowSomeOutput("How many bots? (1-6)");
            int HowMany = inputOutput.IntInput(0, maxBot);

            int HowManyBots = HowMany + 2;

            GamersArray thisGameMembers = new GamersArray();
            Gamer[] GamerArray = thisGameMembers.DoGamerArray(HowManyBots, UserName);

            inputOutput.ShowSomeOutput("New round Start!");

            inputOutput.ShowSomeOutput("Enter your Rate please from 1 $ to 50 $");
            GamerArray[1].GamerRate = inputOutput.IntInput(1, maxRate);

            var newSomeDeck = CardDeck.DoDeck();

            inputOutput.ShowSomeOutput(" New Cards! ");
            FirstRound oneRound = new FirstRound();

            for (int i = 0; i < 2; i++)
            {
                oneRound.DoRound(GamerArray, newSomeDeck);
            }

            inputOutput.ShowSomeOutput(" Cards on Table!");

            for (int i = 0; i < GamerArray.Length; i++)
            {
                while (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Plays)
                {
                    NextRound.RoundForGamer(GamerArray[i], newSomeDeck);
                }
            }

            GameResult gameResult = new GameResult();
            gameResult.DoFinishResult(GamerArray);


            inputOutput.ShowFinishResult(GamerArray);
            Console.ReadLine();
        }

    }
}
