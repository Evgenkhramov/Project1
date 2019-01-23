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
            GameProcess GameProcess = DoGame(Prepare);
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
            gameInfo.UserRate = someGameGetDate.GetGamerRate();

            return gameInfo;
        }

        private GameDeskModel PrepareGame(GameInfoModel gameInfo)
        {
            List<Gamer> GamersList = new List<Gamer>();
            PrepareGamersList botGamers = new PrepareGamersList();
            List<Gamer> AllGamers = botGamers.GenerateBotList(GamersList, gameInfo.HowManyBots);
            AllGamers = botGamers.AddPlayer(AllGamers, gameInfo.UserName, gameInfo.UserRate, GamerRole.Gamer, GamerStatus.Plays);
            AllGamers = botGamers.AddPlayer(AllGamers, TextCuts.DealerName, Settings.DealerRate, GamerRole.Dealer, GamerStatus.Plays);

            var cardDeck = PrepareCardDeck.DoOneDeck();
            PrepareGameDesk prepareGame = new PrepareGameDesk();
            List<Gamer> GamerList = prepareGame.DistributionCards(AllGamers, cardDeck);

            var gameDeskModel = new GameDeskModel();
            gameDeskModel.gamerListAfterPrepare = GamerList;
            gameDeskModel.cardDeck = cardDeck;

            return gameDeskModel;
        }

        private GameProcess DoGame(GameDeskModel gameDeskModel)
        {
            RoundOfGame makeGame = new RoundOfGame();

            foreach (Gamer player in gameDeskModel.gamerListAfterPrepare)
            {
                while (player.Status == GamerStatus.Plays)
                {
                    makeGame.DoRoundForGamer(player, gameDeskModel.cardDeck);
                }
            }
            var gameProcessResult = new GameProcess();
            gameProcessResult.afterGameArray = gameDeskModel.gamerListAfterPrepare;

            return gameProcessResult;
        }

        private void CheckResult(GameProcess result)
        {
            var gameResult = new GameResult();
            var input = new ConsoleInput();
            var output = new ConsoleOutput();

            gameResult.GetFinishResult(result.afterGameArray);

            output.ShowFinishResult(result.afterGameArray);
            output.ShowSomeOutput(TextCuts.GameHistory);
            output.PrintHistory(GameHistory.History);

            input.InputString();
        }
    }
}
