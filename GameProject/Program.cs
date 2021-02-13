using GameProject.Entities;
using GameProject.Management;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.TcNo = "11111";
            gamer1.Name = "Sezer";
            gamer1.Surname = "Bozbıyık";
            gamer1.BirthYear = 1997;
            Gamer gamer2 = new Gamer { TcNo = "22222", Name = "Samet", BirthYear = 1998, Surname = "Vural" };

            Game game1 = new Game { GameName = "PUBG", Id = 1, Price = 90 };
            Game game2 = new Game { GameName = "LOL", Id = 1, Price = 90 };

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "14 Şubat Kampanyası", CampaignDiscount = 35 };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Covid-19 Kampanyası", CampaignDiscount = 55 };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Insert(gamer1);
            gamerManager.Insert(gamer2);

            GameManager gameManager = new GameManager();
            gameManager.Insert(game1);
            gameManager.Insert(game2);

            SalesManager salesmanager = new SalesManager();
            salesmanager.Sales(game1, gamer2);
            salesmanager.CampaignSales(game2, gamer1, campaign1);
        }
    }
}
