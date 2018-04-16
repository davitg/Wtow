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
