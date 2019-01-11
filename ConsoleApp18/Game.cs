using ConsoleApp18.Models;
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
            GameInfoModel Date = GetGameInfo();
            GameDeskModel Prepare =  PrepareGame(Date);
            GameProcess GameProcess =  DoGame(Prepare);
            CheckResult(GameProcess);
        }

        //return model
        private GameInfoModel GetGameInfo()
        {
            var someGameGetDate = new DateFromGamer();
            someGameGetDate.ShowStart();
            string UserName = someGameGetDate.GetUserName();
            int HowManyBots = someGameGetDate.GetNumberOfBots();

            var gameInfo = new GameInfoModel();
            gameInfo.HowManyBots = HowManyBots;
            gameInfo.UserName = UserName;
            gameInfo.GamerRate = someGameGetDate.GetGamerRate ();

            return gameInfo;
        }

        private GameDeskModel PrepareGame(GameInfoModel gameInfo)
        {
            var thisGameMembers = new ArrayOfGamers();
            Gamer[] GamerArray = thisGameMembers.GenerateArrayOfGamers(gameInfo.HowManyBots, gameInfo.UserName);
            GamerArray[1].GamerRate = gameInfo.GamerRate;

            var PrepareThisGame = new PrepareGameDesk();
            var gameDeskModel = new GameDeskModel();
            gameDeskModel.PrepareCardDeck = PrepareThisGame.DistributionCards(GamerArray);
            gameDeskModel.PreparedGamerArray = GamerArray;

            return gameDeskModel;
        }

        private GameProcess DoGame(GameDeskModel gameDeskModel)
        {
            for (int i = 0; i < gameDeskModel.PreparedGamerArray.Length; i++)
            {
                while (gameDeskModel.PreparedGamerArray[i].GamerStatus == Enums.GamerStatusEnum.Plays)
                {
                    RoundOfGame.DoRoundForGamer(gameDeskModel.PreparedGamerArray[i], gameDeskModel.PrepareCardDeck);
                }
            }
            var gameProcessResult = new GameProcess();
            gameProcessResult.AfterGameArray = gameDeskModel.PreparedGamerArray;

            return gameProcessResult;
        }

        private void CheckResult(GameProcess result)
        {
            var gameResult = new GameResult();
            gameResult.DoFinishResult(result.AfterGameArray);
            var inputOutput = new ConsoleInputOutput();
            inputOutput.ShowFinishResult(result.AfterGameArray);

            inputOutput.StringInput();
        }


    }
}
