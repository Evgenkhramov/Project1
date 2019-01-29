using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackProject.Models;

namespace BlackJackProject.Interfeces
{
    public interface IPrint
    {
        void PrintHistory(List<CardHistory> history);
    }
}
