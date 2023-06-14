using Microsoft.AspNetCore.Mvc;

using ModernVilla_VillaAPI.Data;
using ModernVilla_VillaAPI.Models;
using ModernVilla_VillaAPI.Models.Dto;

namespace ModernVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("{id:int}")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u=>u.Id==id);
        }
    }
}
