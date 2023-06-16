﻿using ModernVilla_Utility;
using static ModernVilla_Utility.SD;

namespace ModernVilla_Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
    }
}
