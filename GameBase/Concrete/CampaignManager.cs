using GameBase.Abstract;
using GameBase.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBase.Concrete
{
    public class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName+": Kampanya Başarıyla Eklenmiştir.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+": Kampanya Başarıyla Silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+": Kampanya Başarıyla Güncellenmiştir.");
        }
    }
}
