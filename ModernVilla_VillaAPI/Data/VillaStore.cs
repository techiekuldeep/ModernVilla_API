using ModernVilla_VillaAPI.Models.Dto;

namespace ModernVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>{
                new VillaDTO{Id=1, Name = "Pool View", Sqft=150, Occupancy=4 },
                new VillaDTO{Id=2, Name = "Beach View",Sqft=250, Occupancy=5 }
            };
    }
}
