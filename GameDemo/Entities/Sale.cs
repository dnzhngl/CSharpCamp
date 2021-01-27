using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }

        public int GamerId { get; set; }
        public Gamer Gamer { get; set; }

        public ICollection<Campaign> Campaigns { get; set; }
    }
}
