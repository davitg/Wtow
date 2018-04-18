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
                .GroupJoin(_context.UserTitleMaps.Where(m => m.User.UserName == username),
                      t => t.TitleId,
                      m => m.TitleId,
                      (t, m) =>  new { Title = t, Users = m})
                .SelectMany(
                      x => x.Users.DefaultIfEmpty(),
                      (t,m) =>  
                      new UserTitle()
                      {
                          TitleId = t.Title.TitleId,
                          Name = t.Title.Name,
                          Year = t.Title.Year,
                          Rated = t.Title.Rated,
                          Released = t.Title.Released,
                          Runtime = t.Title.Runtime,
                          Genre = t.Title.Genre,
                          Director = t.Title.Director,
                          Writer = t.Title.Writer,
                          Actors = t.Title.Actors,
                          Plot = t.Title.Plot,
                          Language = t.Title.Language,
                          Country = t.Title.Country,
                          Awards = t.Title.Awards,
                          Poster = t.Title.Poster,
                          Ratings = t.Title.Ratings,
                          Metascore = t.Title.Metascore,
                          ImdbRating = t.Title.ImdbRating,
                          ImdbVotes = t.Title.ImdbVotes,
                          ImdbId = t.Title.ImdbId,
                          TitleType = t.Title.TitleType,
                          DVD = t.Title.DVD,
                          BoxOffice = t.Title.BoxOffice,
                          Production = t.Title.Production,
                          Website = t.Title.Website,
                          UserTitleMapId = m.UserTitleMapId,
                         // UserId = m.UserId,
                          UserRaiting = m.Raiting,
                          UserWatchList = m.WatchList,
                          UserReview = m.Review,
                          UserReviewDate = m.ReviewDate
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
