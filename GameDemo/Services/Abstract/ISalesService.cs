using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services.Abstract
{
    interface ISalesService
    {
        public void Add(Sale sale);
        public void Delete(int saleId);
        public void Update(Sale sale);
    }
}
