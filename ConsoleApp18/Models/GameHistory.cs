using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject.Models
{
    
    public class GameHistory
    {
        public static List<CardHistory> History = new List<CardHistory>();
        public static void AddGameHistory(List<CardHistory> historyList, Gamer gamer, OneCard oneCard)
        {
            CardHistory newRecord = new CardHistory(gamer.Name, gamer.Points, oneCard);
           
            historyList.Add(newRecord);

        }
        
    }
}
