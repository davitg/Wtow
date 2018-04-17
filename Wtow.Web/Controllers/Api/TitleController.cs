using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Domain;
using Wtow.Service;

namespace Wtow.Web.Controllers.Api
{
    [Route("api/[Controller]")]
    public class TitleController : Controller
    {
        private readonly ITitleService _titleService;

        public TitleController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet]
        public List<Title> GetAll()
        {
            return _titleService.GetAllTitles();
        }

    }
}
