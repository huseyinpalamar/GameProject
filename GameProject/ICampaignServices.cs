using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignServices
    {
        void AddCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);

    }
}
