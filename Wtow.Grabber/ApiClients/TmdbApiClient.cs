using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Wtow.Domain;

namespace Wtow.Grabber.ApiClients
{
    public class TmdbApiClient
    {
        private readonly IConfigurationRoot _config;
        private readonly IMapper _mapper;
        static HttpClient client = new HttpClient();


        public TmdbApiClient(IConfigurationRoot config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
        }

        public async Task<Title> GetTitleByImdbId(string imdbId)
        {
            throw new NotImplementedException();
        }
    }
}
