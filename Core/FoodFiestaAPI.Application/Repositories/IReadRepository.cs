using FoodFiestaAPI.Domain.Entities.Common;
using System.Linq.Expressions;

namespace FoodFiestaAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntitiy
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true); //Asekron olarak çalışacak
        Task<T> GetByIdAsync(string id, bool tracking = true); //Asenkron olarak çalışacak
    }
}
