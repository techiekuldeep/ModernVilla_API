using AutoMapper;
using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ModernVilla_VillaAPI.Data;
using ModernVilla_VillaAPI.Logging;
using ModernVilla_VillaAPI.Models;
using ModernVilla_VillaAPI.Models.Dto;
using ModernVilla_VillaAPI.Repository.IRepository;

using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IMapper _mapper;
        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            this._response = new();
            _dbVilla = dbVilla;
        }


        [MapToApiVersion("2.0")]
        [HttpGet("GetString")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Kuldeep", "Singh" };
        }

    }
}
