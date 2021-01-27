using GameDemo.Entities;
using GameDemo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    class SalesManager : ISalesService
    {
        private readonly GameDb gameDb;
        public SalesManager(GameDb _gameDb)
        {
            gameDb = _gameDb;
        }

        public void Add(Sale sale)
        {
            gameDb.Sales.Add(sale);

            var campaignNames = "";
            var discounts = "";
            foreach (var campaign in sale.Campaigns)
            {
                campaignNames += $"{campaign.Name} ";
                discounts = $"{campaign.Discount}, ";
            }
            Console.WriteLine($"{sale.Gamer.UserName} adlı oyuncu {campaignNames} kampanyası ile {discounts} indirim ile oyunu satın aldı.");
        }

        public void Delete(int saleId)
        {
            var sale = gameDb.Sales.Find(s => s.Id == saleId);
            gameDb.Sales.Remove(sale);
            Console.WriteLine("Satış işlemi sistemden silindi.");
        }

        public void Update(Sale sale)
        {
            var oldSale = gameDb.Sales.Find(s => s.Id == sale.Id);
            oldSale = sale;
            Console.WriteLine("Satış işlemi başarıyla güncellendi.");
        }
    }
}
