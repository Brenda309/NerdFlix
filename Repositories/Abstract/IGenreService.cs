using NerdFlix.Models.Domain;
using NerdFlix.Models.DTO;

namespace NerdFlix.Repositories.Abstract
{
    public interface IGenreService
    {
        bool Add(Genre model);
        bool Update(Genre model);
        Genre GetById(int id);
        bool Delete(int id);
        IQueryable<Genre> List();

    }
}