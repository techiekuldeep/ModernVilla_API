﻿using Microsoft.AspNetCore.Mvc;

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
            return new List<VillaDTO>{
                new VillaDTO{Id=1, Name = "Pool View" },
                new VillaDTO{Id=2, Name = "Beach View" }
            };
        }
    }
}
