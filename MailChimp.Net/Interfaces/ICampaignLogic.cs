﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using MailChimp.Net.Requests;

namespace MailChimp.Net.Logic
{
    public interface ICampaignLogic
    {
        Task<IEnumerable<Campaign>> GetAll(CampaignRequest request = null);
        Task<Campaign> GetAsync(string id);
    }
}