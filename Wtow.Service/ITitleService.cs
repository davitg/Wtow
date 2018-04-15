using System;
using System.Collections.Generic;
using Wtow.Domain;

namespace Wtow.Service
{
    public interface ITitleService
    {
        Title GetTitleByImdbId(string imdbId);
        Title GetTitleById(int id);
        List<Title> GetAllTitles();
        void AddTitle(Title title);

    }
}
