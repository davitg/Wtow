using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Domain;
using Wtow.Grabber.ApiClients;
using Wtow.Service;

namespace Wtow.Grabber.Grabbers
{
    public class OmdbGrabber
    {
        private readonly OmdbApiClient _apiParser;
        private readonly ITitleService _titleService;
        private readonly ILog _log;

        public OmdbGrabber(OmdbApiClient apiParser, ITitleService titleService, ILog log)
        {
            _apiParser = apiParser;
            _titleService = titleService;
            _log = log;
        }

        public void GrabByImdbIds(string[] imdbIds)
        {
            List<Title> titles;

            titles = _titleService.GetAllTitles();

            foreach (string imdbId in imdbIds)
            {
                try
                {
                    var exists = titles.Where(t => t.ImdbId == imdbId).Any();

                    if (exists)
                        continue;

                    Console.WriteLine($"Calling OMDb APi for '{imdbId}'");
                    _log.Info($"Calling OMDb APi for '{imdbId}'");

                    var title = _apiParser.GetTitleByImdbId(imdbId).Result;

                    if (!String.IsNullOrEmpty(title.Name))
                    {
                        Console.WriteLine($"Saving Title Name:'{title.Name}'  IMDb Id:'{imdbId}'");
                        _log.Info($"Saving Title Name:'{title.Name}'  IMDb Id:'{imdbId}'");
                        _titleService.AddTitle(title);
                    }
                }
                catch (Exception ex)
                {
                    _log.Error(ex.ToString());
                }
            }
        }
    }
}
