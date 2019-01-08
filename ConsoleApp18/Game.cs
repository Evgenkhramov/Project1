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
            DateFromGamer someGameGetDate = new DateFromGamer();
            someGameGetDate.ShowStart();
            string UserName = someGameGetDate.GetUserName();
            int HowManyBots = someGameGetDate.HowBots();                                  

            GamersArray thisGameMembers = new GamersArray();
            Gamer[] GamerArray = thisGameMembers.DoGamerArray(HowManyBots, UserName);
            GamerArray[1].GamerRate = someGameGetDate.GamerRate();
            PrepareGame PrepareThisGame = new PrepareGame();
            PrepareThisGame.DoPrepare(GamerArray);

            for (int i = 0; i < GamerArray.Length; i++)
            {
                while (GamerArray[i].GamerStatus == Gamer.GamerStatusEnum.Plays)
                {
                    NextRound.RoundForGamer(GamerArray[i], PrepareThisGame.newSomeDeck);
                }
            }
            GameResult gameResult = new GameResult();
            gameResult.DoFinishResult(GamerArray);
            InputOutput inputOutput = new InputOutput();
            inputOutput.ShowFinishResult(GamerArray);
            Console.ReadLine();
        }

    }
}
