using GameDemo.Entities;
using GameDemo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    class CampaignManager : ICampaignService
    {
        private readonly GameDb gameDb;
        public CampaignManager(GameDb _gameDb)
        {
            gameDb = _gameDb;
        }
        public void Add(Campaign campaign)
        {
            gameDb.Campaigns.Add(campaign);
            Console.WriteLine("Kampanya sisteme başarıyla eklenmiştir.");
        }
        public void Delete(int campaignId)
        {
            var campaign = gameDb.Campaigns.Find(c => c.Id == campaignId);
            gameDb.Campaigns.Remove(campaign);
            Console.WriteLine("Kampanya sistemden başarıyla silindi.");
        }
        public void Update(Campaign campaign)
        {
            var oldCampaign = gameDb.Campaigns.Find(c => c.Id == campaign.Id);
            oldCampaign = campaign;
            Console.WriteLine($"{campaign.Name} adlı kampanya başarıyla güncellendi");
        }
    }
}
