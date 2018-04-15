using AutoMapper;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Wtow.Domain;
using Wtow.Grabber.Domain;

namespace Wtow.Grabber.ApiClients
{
    public class OmdbApiClient
    {
        private readonly IConfigurationRoot _config;
        private readonly IMapper _mapper;
        static HttpClient client = new HttpClient();


        public OmdbApiClient(IConfigurationRoot config, IMapper mapper)
        {
            _config = config;
            _mapper = mapper;
        }

        public async Task<Title> GetTitleByImdbId(string imdbId)
        {
            var key = _config["OMDbKey"];
            var path = $"http://www.omdbapi.com/?i={imdbId}&apikey={key}";
            OmdbTitle title = null;
            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                title = await response.Content.ReadAsJsonAsync<OmdbTitle>();
            }
            return _mapper.Map<OmdbTitle, Title>(title);
        }
    }

  
}
