using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Models;

namespace BlackJackProject
{
    public class HelperTextFileHistory
    {
        public void WriteHistoryStringToFile(string fullFileName, List<CardHistory> historyList)
        {

            try
            {
                StreamWriter strimWrite = new StreamWriter(fullFileName);
                foreach (CardHistory element in historyList)
                {
                    strimWrite.WriteLine($"{element.GamerName} get card {element.CardOfRound.CardNumber} {element.CardOfRound.CardSuit}  and get {element.GamerPoints}");
                    
                }
                strimWrite.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}

