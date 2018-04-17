using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserTitleController : Controller
    {
        private readonly ITitleService _titleService;
        private readonly UserManager<AppUser> _userManager;

        public UserTitleController(ITitleService titleService, UserManager<AppUser> userManager)
        {
            _titleService = titleService;
            _userManager = userManager;
        }

        [HttpGet]
        public List<UserTitle> GetUserTitles()
        {
            var username = User.Identity.Name;
            return _titleService.GetUserTitles(username);
        }
    }
}
