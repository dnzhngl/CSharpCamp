using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services.Abstract
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(int campaignId);
        public void Update(Campaign campaign);
    }
}
