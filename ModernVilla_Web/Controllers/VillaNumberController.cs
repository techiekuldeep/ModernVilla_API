﻿using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using ModernVilla_Web.Models;
using ModernVilla_Web.Models.Dto;
using ModernVilla_Web.Services;
using ModernVilla_Web.Services.IServices;

using Newtonsoft.Json;

namespace ModernVilla_Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IVillaNumberService _villaNumberService;
        private readonly IMapper _mapper;
        public VillaNumberController(IVillaNumberService villaNumberService, IMapper mapper)
        {
            _villaNumberService = villaNumberService;
            _mapper = mapper;
        }
        public async Task<IActionResult> IndexVillaNumber()
        {
            List<VillaNumberDTO> list = new();
            var response = await _villaNumberService.GetAllAsync<APIResponse>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaNumberDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}
