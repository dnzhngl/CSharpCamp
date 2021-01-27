using GameDemo.Entities;
using GameDemo.Services;
using GameDemo.Services.Concrete;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameDb gameDb = new GameDb();
            var validation = new UserValidationManager();
            var gamerManager = new GamerManager(validation, gameDb);
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                UserName = "salsağ",
                Email = "salsağ@hotmail.com",
                FirstName = "Salih",
                LastName = "Sağsalim",
                IdentityNo = "11111111111",
                DOB = new DateTime(01 / 01 / 199)
            };
            Gamer gamer2 = new Gamer
            {
                Id = 1,
                UserName = "salsağ2",
                Email = "salsağ@hotmail.com",
                FirstName = "Salih",
                LastName = "Sağsalim",
                IdentityNo = "11111111111",
                DOB = new DateTime(01 / 01 / 199)
            };
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            var salesManager = new SalesManager(gameDb);
            var campaignManager = new CampaignManager(gameDb);
            var campaignList = new List<Campaign>();
            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "No Campaign",
                Discount = 0
            };
            campaignList.Add(campaign);

            Sale sale = new Sale
            {
                Id = 1,
                GamerId = 1,
                Gamer = gamer1,
                SaleDate = DateTime.Now,
                Campaigns = campaignList
            };

            salesManager.Add(sale);

        }
    }
}
