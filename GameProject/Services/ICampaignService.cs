using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Insert(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
