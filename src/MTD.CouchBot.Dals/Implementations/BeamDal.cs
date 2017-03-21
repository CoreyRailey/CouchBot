﻿using MTD.CouchBot.Domain.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MTD.CouchBot.Dals.Implementations
{
    public class BeamDal : IBeamDal
    {
        public async Task<BeamChannel> GetBeamChannelByName(string name)
        {

            var baseUrl = "https://beam.pro/api/v1";

            var request = (HttpWebRequest)WebRequest.Create(baseUrl + "/channels/" + name);
            request.ContentType = "application/json; charset=utf-8";
            var response = await request.GetResponseAsync();
            var responseText = "";

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                responseText = sr.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<BeamChannel>(responseText);
            
        }
    }
}
