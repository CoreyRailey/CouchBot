﻿using MTD.CouchBot.Dals;
using MTD.CouchBot.Dals.Implementations;
using MTD.CouchBot.Domain.Models.Smashcast;
using System.Threading.Tasks;

namespace MTD.CouchBot.Managers.Implementations
{
    public class SmashcastManager : ISmashcastManager
    {
        ISmashcastDal smashcastDal;

        public SmashcastManager()
        {
            smashcastDal = new SmashcastDal();
        }

        public async Task<SmashcastChannel> GetChannelByName(string name)
        {
            return await smashcastDal.GetChannelByName(name);
        }
    }
}
