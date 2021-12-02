using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    public class GamblingBet
    {
        public void Add()
        {
            int bet = 1;
            int get = 1;
            Random random = new Random();
            if(bet==get)
            {
                Console.WriteLine("Win");
            }
            else
            {
                Console.WriteLine("Loss");
            }
        }
    }
}
