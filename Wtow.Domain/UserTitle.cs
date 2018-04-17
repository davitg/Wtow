﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Domain
{
    public class UserTitle : Title
    {
        public int UserTitleMapId { get; set; }


        public string UserId { get; set; }
        public int Raiting { get; set; }
        public bool WatchList { get; set; }
        public string Review { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
