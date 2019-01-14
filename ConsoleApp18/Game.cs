using BlackJackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    class Game
    {
        Settings game = new Settings();

        public Game()
        {
            GameInfoModel date = GetGameInfo();
            GameDeskModel prepare =  PrepareGame(date);
            GameProcess gameProcess =  DoGame(prepare);
            CheckResult(gameProcess);
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
            GamerArray[1].Rate = gameInfo.GamerRate;

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
                while (gameDeskModel.PreparedGamerArray[i].Status == Enums.GamerStatus.Plays)
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
            var inputOutput = new ConsoleInputOutput();

            gameResult.GetFinishResult(result.AfterGameArray);

            inputOutput.ShowFinishResult(result.AfterGameArray);

            inputOutput.StringInput();
        }
    }
}
