using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Management
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " oyununu " + gamer.Name + " kullanıcısı " + campaign.CampaignName + " ile satın aldı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " oyununu " + gamer.Name + " kullanıcısı aldı. ");
        }
    }
}
