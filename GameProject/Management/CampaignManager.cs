using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Management
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Insert(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
