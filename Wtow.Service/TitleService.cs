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

        public async Task<List<Title>> GetAllTitles()
        {
            return await _context.Titles
                                 .ToListAsync();
        }

        public async Task<List<UserTitle>> GetUserTitles(string userId)
        {
            try
            {
                return await _context.Titles
                            .Include(t => t.Ratings)
                            .GroupJoin(_context.UserTitleMaps.Where(m => userId != null && m.UserId == userId),
                                  t => t.TitleId,
                                  m => m.TitleId,
                                  (t, m) => new { Title = t, Users = m })
                            .SelectMany(
                                  x => x.Users.DefaultIfEmpty(),
                                  (t, m) =>
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
                                      UserTitleMapId = m != null ? (int?)m.UserTitleMapId : null,
                                      UserRaiting = m != null ? (int?)m.Raiting : null,
                                      UserWatchList = m != null ? m.WatchList : false,
                                      UserReview = m != null ? m.Review : null,
                                      UserReviewDate = m != null ? m.ReviewDate : null
                                  })
                               .Take(5)
                            .ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<Title> GetTitleById(int id)
        {
            return await _context.Titles
                .Include(t => t.Ratings)
                .Where(t => t.TitleId == id)
                .SingleOrDefaultAsync();
        }

        public async Task<Title> GetTitleByImdbId(string imdbId)
        {
            return await _context.Titles
              .Include(t => t.Ratings)
              .Where(t => t.ImdbId == imdbId)
              .SingleOrDefaultAsync();
        }

        public async Task<bool> AddTitle(Title title)
        {
            _context.Titles.Add(title);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> TitleRate(int titleId, int rating, string userId)
        {
            if (_context.Titles.Find(titleId) != null)
            {

                var map = _context.UserTitleMaps
                    .Where(m => m.TitleId == titleId && m.UserId == userId)
                    .SingleOrDefault();

                if (map != null)
                {
                    map.Raiting = rating;
                    //_context.Entry(map).State = EntityState.Modified;
                }
                else
                {
                    _context.UserTitleMaps
                            .Add(new UserTitleMap() { TitleId = titleId, UserId = userId, Raiting = rating });
                }


                await _context.SaveChangesAsync();
                return true;
            }

            throw new Exception("Title not found");
        }


    }
}
