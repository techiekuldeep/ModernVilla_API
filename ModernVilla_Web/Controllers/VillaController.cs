﻿using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using ModernVilla_Web.Models;
using ModernVilla_Web.Models.Dto;
using ModernVilla_Web.Services.IServices;

using Newtonsoft.Json;

namespace ModernVilla_Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public VillaController(IVillaService villaService, IMapper mapper)
        {
                _villaService = villaService;
                _mapper = mapper;
        }
        public async Task<IActionResult> IndexVilla()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}
