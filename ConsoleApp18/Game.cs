using BlackJackProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Constanta;
using BlackJackProject.Enums;
//using Ninject;


namespace BlackJackProject
{
    class Game
    {
        Settings game;

        public Game()
        {
            game = new Settings();
            GameInfoModel Date = GetGameInfo();
            GameDeskModel Prepare = PrepareGame(Date);
            GameProcess GameProcess = DoGame(Prepare);
            CheckResult(GameProcess);
        }
        //return model
        private GameInfoModel GetGameInfo()
        {
            var ConsoleOut = new ConsoleOutput();
            var ConsoleInp = new ConsoleInput();

            var someGameGetDate = new DateFromGamer(ConsoleOut, ConsoleInp);
            someGameGetDate.ShowStart();
            string UserName = someGameGetDate.GetUserName();
            int HowManyBots = someGameGetDate.GetNumberOfBots();

            var gameInfo = new GameInfoModel
            {
                HowManyBots = HowManyBots,
                UserName = UserName,
                UserRate = someGameGetDate.GetGamerRate()
            };

            return gameInfo;
        }

        private GameDeskModel PrepareGame(GameInfoModel gameInfo)
        {
            var ConsoleOut = new ConsoleOutput();

            List<Gamer> GamersList = new List<Gamer>();
            PrepareGamersList botGamers = new PrepareGamersList();
            List<Gamer> AllGamers = botGamers.GenerateBotList(GamersList, gameInfo.HowManyBots);
            AllGamers = botGamers.AddPlayer(AllGamers, gameInfo.UserName, gameInfo.UserRate, GamerRole.Gamer, GamerStatus.Plays);
            AllGamers = botGamers.AddPlayer(AllGamers, TextCuts.DealerName, Settings.DealerRate, GamerRole.Dealer, GamerStatus.Plays);

            var cardDeck = PrepareCardDeck.DoOneDeck();
            var prepareGame = new PrepareGameDesk(ConsoleOut);
            List<Gamer> GamerList = prepareGame.DistributionCards(AllGamers, cardDeck);

            var gameDeskModel = new GameDeskModel
            {
                gamerListAfterPrepare = GamerList,
                cardDeckAfterPrepare = cardDeck
            };

            return gameDeskModel;
        }

        private GameProcess DoGame(GameDeskModel gameDeskModel)
        {
            RoundOfGame makeGame = new RoundOfGame();

            foreach (Gamer player in gameDeskModel.gamerListAfterPrepare)
            {
                while (player.Status == GamerStatus.Plays)
                {
                    makeGame.DoRoundForGamer(player, gameDeskModel.cardDeckAfterPrepare);
                }
            }
            var gameProcessResult = new GameProcess
            {
                afterGameArray = gameDeskModel.gamerListAfterPrepare
            };

            return gameProcessResult;
        }

        private void CheckResult(GameProcess result)
        {
            var gameResult = new GameResult();
            var consoleOut = new ConsoleOutput();
            var consoleInp = new ConsoleInput();
            var createDirectory = new DirectoryAndFileOfHistory();

            gameResult.GetFinishResult(result.afterGameArray);

            consoleOut.ShowFinishResult(result.afterGameArray);
            consoleOut.ShowSomeOutput(TextCuts.GameHistory);
            consoleOut.PrintHistory(GameHistoryList.History);
            string fullName = createDirectory.CreateDirectory(Settings.HistoryDirectoryPath, Settings.HistoryDirectorySubPath);
            string fullFileName = createDirectory.CreateFile(Settings.HistoryFileName, fullName);
            HelperTextFileHistory textFile = new HelperTextFileHistory();
            textFile.WriteHistoryStringToFile(fullFileName, GameHistoryList.History);

            consoleInp.InputString();
        }
    }
}
