﻿using YcTeam.DAL;
using YcTeam.IDAL.Master;
using YcTeam.Models;
using YcTeam.Models.Master;

namespace YcTeam.IDAL.Master
{
    public class ProviderDao : BaseService<Provider>, IProviderDao
    {
        public ProviderDao() : base(new YcContext())
        {

        }
    }
}
