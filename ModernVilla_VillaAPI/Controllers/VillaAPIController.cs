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
        public ActionResult<VillaDTO> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            return Ok(VillaStore.villaList.FirstOrDefault(u=>u.Id==id));
        }
    }
}
