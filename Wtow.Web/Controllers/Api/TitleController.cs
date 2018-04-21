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
using Wtow.Web.Models;

namespace Wtow.Web.Controllers.Api
{
    [Route("api/[Controller]")]
    public class TitleController : Controller
    {
        private readonly ITitleService _titleService;
        private readonly UserManager<AppUser> _userManager;

        public TitleController(ITitleService titleService, UserManager<AppUser> userManager)
        {
            _titleService = titleService;
            _userManager = userManager;
        }

        [HttpGet("GetAll")]
        public async Task<List<UserTitle>> GetAll()
        {
            string userId = null;
            if (User.Identity.Name != null)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                userId = user?.Id;
            }

            return await _titleService.GetUserTitles(userId);
        }


        [HttpPost("Rate")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> TitleRate([FromBody]TitleRateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            string userId = null;
            if (User.Identity.Name != null)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                userId = user?.Id;
            }

            await _titleService.TitleRate(model.TitleId, model.Raiting, userId);

            return Ok(true);
        }

    }
}
