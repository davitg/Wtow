using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Domain
{
    public class UserTitle : Title
    {
        public int UserTitleMapId { get; set; }


       // public string       UserId          { get; set; }
        public int          UserRaiting     { get; set; }
        public bool         UserWatchList   { get; set; }
        public string       UserReview      { get; set; }
        public DateTime?    UserReviewDate  { get; set; }
    }
}
