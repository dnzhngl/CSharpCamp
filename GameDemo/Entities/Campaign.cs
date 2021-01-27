using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class Campaign : EntityBase
    {
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
