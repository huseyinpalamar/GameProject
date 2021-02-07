using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : GameServices
    {
        public void GameSale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName+":"+game.GamePrice+":"+gamer.FisrtName+"Tarafından Satıldı");
        }
    }
}
