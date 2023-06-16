using ModernVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace ModernVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository :IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
