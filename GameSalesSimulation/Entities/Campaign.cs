using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSimulation.Entities
{
    class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
