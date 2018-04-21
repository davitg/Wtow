using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wtow.Web.Models
{
    public class TitleRateModel
    {
        [Required]
        public int TitleId { get; set; }

        [Required]
        [Range(0,100)]
        public int Raiting { get; set; }
    }
}
