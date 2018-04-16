using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Data;
using Wtow.Domain;

namespace Wtow.Service
{
    public class UserTitleService
    {
        private readonly TitleContext _context;

        public UserTitleService(TitleContext context)
        {
            _context = context;
        }

        public void GetAllTitles(string userId)
        {
           


        }

    }
}
