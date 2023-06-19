﻿using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using ModernVilla_Utility;

using ModernVilla_Web.Models;
using ModernVilla_Web.Models.Dto;
using ModernVilla_Web.Services.IServices;

using Newtonsoft.Json;

using System.Diagnostics;

namespace ModernVilla_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVillaService _villaService;
        private readonly IMapper _mapper;

        public HomeController(IVillaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }
    }
}