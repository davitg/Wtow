using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Domain
{
    public class UserTitle
    {
        public int UserTitleId { get; set; }
        public Title Title { get; set; }
        public AppUser User { get; set; }
        public int Raiting { get; set; }
        public bool Watched { get; set; }
        public string Review { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
