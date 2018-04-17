using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Data;
using Wtow.Domain;

namespace Wtow.Service
{
    public class TitleService : ITitleService
    {
        private readonly TitleContext _context;

        public TitleService(TitleContext context)
        {
            _context = context;
        }

        public void AddTitle(Title title)
        {


            _context.Titles.Add(title);
            _context.SaveChanges();
        }

        public List<Title> GetAllTitles()
        {
            return _context.Titles
                .Include(t => t.Ratings)
                .ToList();
        }

        public List<UserTitle> GetUserTitles(string username)
        {
            return _context.Titles
                .Include(t => t.Ratings)
                .Join(_context.UserTitleMaps.Where(m => m.User.UserName == username),
                      t => t.TitleId,
                      m => m.TitleId,
                      (t, m) => new UserTitle()
                      {
                          TitleId = t.TitleId,
                          Name = t.Name,
                          Year = t.Year,
                          Rated = t.Rated,
                          Released = t.Released,
                          Runtime = t.Runtime,
                          Genre = t.Genre,
                          Director = t.Director,
                          Writer = t.Writer,
                          Actors = t.Actors,
                          Plot = t.Plot,
                          Language = t.Language,
                          Country = t.Country,
                          Awards = t.Awards,
                          Poster = t.Poster,
                          Ratings = t.Ratings,
                          Metascore = t.Metascore,
                          ImdbRating = t.ImdbRating,
                          ImdbVotes = t.ImdbVotes,
                          ImdbId = t.ImdbId,
                          TitleType = t.TitleType,
                          DVD = t.DVD,
                          BoxOffice = t.BoxOffice,
                          Production = t.Production,
                          Website = t.Website,
                          UserTitleMapId = m.UserTitleMapId,
                          UserId = m.UserId,
                          Raiting = m.Raiting,
                          WatchList = m.WatchList,
                          Review = m.Review,
                          ReviewDate = m.ReviewDate
                      })
                .ToList();
        }



        public Title GetTitleById(int id)
        {
            return _context.Titles
                .Include(t => t.Ratings)
                .Where(t => t.TitleId == id)
                .SingleOrDefault();
        }


        public Title GetTitleByImdbId(string imdbId)
        {
            return _context.Titles
              .Include(t => t.Ratings)
              .Where(t => t.ImdbId == imdbId)
              .SingleOrDefault();
        }
    }
}
