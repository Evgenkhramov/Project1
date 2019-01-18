using BlackJackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;
using BlackJackProject.Enums;

namespace BlackJackProject
{
    class Game
    {
        Settings GameSettings = new Settings();

        public Game()
        {
            GameInfoModel Date = GetGameInfo();
            GameDeskModel Prepare = PrepareGame(Date);
            GameProcess gameProcess = DoGame(Prepare);
            CheckResult(gameProcess);
        }

        //return model
        private GameInfoModel GetGameInfo()
        {
            var SomeGameGetDate = new DateFromGamer();
            SomeGameGetDate.ShowStart();
            string UserName = SomeGameGetDate.GetUserName();
            int HowManyBots = SomeGameGetDate.GetNumberOfBots();

            var gameInfo = new GameInfoModel();
            gameInfo.HowManyBots = HowManyBots;
            gameInfo.UserName = UserName;
            gameInfo.UserRate = SomeGameGetDate.GetGamerRate();

            return gameInfo;
        }

        private GameDeskModel PrepareGame(GameInfoModel gameInfo)
        {
            List<Gamer> GamersList = new List<Gamer>();
            PrepareGamersList BotGamers = new PrepareGamersList();
            List<Gamer> AllGamers = BotGamers.GenerateBotList(GamersList, gameInfo.HowManyBots);
            AllGamers = BotGamers.AddPlayer(AllGamers, gameInfo.UserName, gameInfo.UserRate, GamerRole.Gamer, GamerStatus.Plays);
            AllGamers = BotGamers.AddPlayer(AllGamers, TextCuts.DealerName, Settings.DealerRate, GamerRole.Dealer, GamerStatus.Plays);

            var cardDeck = PrepareCardDeck.DoOneDeck();
            PrepareGameDesk PrepareGame = new PrepareGameDesk();
            List<Gamer> GamerList = PrepareGame.DistributionCards(AllGamers, cardDeck);

            var gameDeskModel = new GameDeskModel();
            gameDeskModel.GamerListAfterPrepare = GamerList;
            gameDeskModel.cardDeck = cardDeck;

            return gameDeskModel;
        }

        private GameProcess DoGame(GameDeskModel gameDeskModel)
        {
            RoundOfGame makeGame = new RoundOfGame();

            foreach (Gamer player in gameDeskModel.GamerListAfterPrepare)
            {
                while (player.Status == GamerStatus.Plays)
                {
                    makeGame.DoRoundForGamer(player, gameDeskModel.cardDeck);
                }
            }
            var gameProcessResult = new GameProcess();
            gameProcessResult.AfterGameArray = gameDeskModel.GamerListAfterPrepare;

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
