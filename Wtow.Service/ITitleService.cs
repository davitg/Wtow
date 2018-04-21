using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wtow.Domain;

namespace Wtow.Service
{
    public interface ITitleService
    {
        Task<List<Title>> GetAllTitles();
        Task<List<UserTitle>> GetUserTitles(string userId);
        // Task<Title> GetTitleById(int id);
        // Task<Title> GetTitleByImdbId(string imdbId);

        Task<bool> AddTitle(Title title);
        Task<bool> TitleRate(int titleId, int rating, string userId);

    }
}
