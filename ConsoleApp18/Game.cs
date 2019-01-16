using BlackJackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;

namespace BlackJackProject
{
    class Game
    {
        Settings game = new Settings();

        public Game()
        {
            GameInfoModel date = GetGameInfo();
            GameDeskModel prepare = PrepareGame(date);
            GameProcess gameProcess = DoGame(prepare);
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
            gameInfo.UserRate = someGameGetDate.GetGamerRate();

            return gameInfo;
        }

        private GameDeskModel PrepareGame(GameInfoModel gameInfo)
        {

            List<Gamer> GamersList = new List<Gamer>();
            PrepareGamersList BotGamers = new PrepareGamersList();
            BotGamers.GenerateBotList(GamersList, )


            var User = new Gamer();
            User.Name = gameInfo.UserName;
            User.Rate = gameInfo.UserRate;

            var DealerOfGame = new Gamer();
            DealerOfGame.Name = TextCuts.DealerName;

            //var botsMembers = new ArrayOfBots();
            //Gamer[] arrayOfBots = botsMembers.GenerateArrayOfBots(gameInfo.HowManyBots, TextCuts.BotName, Settings.BotRate);

            //var PrepareThisGame = new PrepareGameDesk();
            //var gameDeskModel = new GameDeskModel();

            //gameDeskModel.PrepareCardDeck = PrepareThisGame.DistributionCards(arrayOfBots);
            //gameDeskModel.PreparedGamerArray = arrayOfBots;

            //return gameDeskModel;
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
            var input = new ConsoleInput();
            var output = new ConsoleOutput();

            gameResult.GetFinishResult(result.AfterGameArray);

            output.ShowFinishResult(result.AfterGameArray);

            input.InputString();
        }
    }
}
