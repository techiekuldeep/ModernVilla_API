using ModernVilla_VillaAPI.Models;

namespace ModernVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository :IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
