﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    public class Wallet
    {   // Member Variables

        public List<Coin> coin; 

        public Wallet()
        {  // constructor

            coin = new List<Coin>();
            AddCoins(); 
            // Wallet is stocked to begin exercise with $5 in change.
        }
        void AddCoins()
        {   // member method

            for (int i = 0; i <6; i++)
            {
                Quarter quarter = new Quarter();
                coin.Add(quarter);
            }
            for (int i = 0; i <20; i++) 
            {
                Dime dime = new Dime();
                coin.Add(dime);
            }
            for (int i = 0; i <20; i++) 
            {
                Nickel nickel = new Nickel();
                coin.Add(nickel);
            }
            for (int i = 0; i < 50; i++) 
            {
                Penny penny = new Penny();
                coin.Add(penny);
            }

        }
       void SpendCoins() 
       {

            // Credit card (extra credit only if I get there create Card class with avail funds double )
            // I want to have the coins im using as payment added to a list
            // cans should be bought with coins out of wallet then put in backpack



       }


    }
}
