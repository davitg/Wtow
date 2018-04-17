using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Domain
{
    public class UserTitleMap
    {
        public int UserTitleMapId { get; set; }

        public int TitleId { get; set; }
        public Title Title { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int Raiting { get; set; }
        public bool WatchList { get; set; }
        public string Review { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
