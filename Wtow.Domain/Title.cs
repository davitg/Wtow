using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Domain
{
    public class Title
    {

        public Title()
        {
            Ratings = new List<Rating>();
        }


        public int TitleId { get; set; }

        public string Name { get; set; }
        public int Year { get; set; }
        public string Rated { get; set; }
        public DateTime? Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public List<Rating> Ratings { get; set; }
        public float Metascore { get; set; }
        public float ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbId { get; set; }
        public TitleType TitleType { get; set; }
        public DateTime? DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }
    }
}
