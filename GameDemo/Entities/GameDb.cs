using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class GameDb 
    {
        public GameDb()
        {
            Campaigns = new List<Campaign>();
            Gamers = new List<Gamer>();
            Sales = new List<Sale>();
        }
        public List<Campaign> Campaigns { get; set; }
        public List<Gamer> Gamers { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
