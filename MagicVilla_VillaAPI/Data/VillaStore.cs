using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
              new VillaDTO { Id = 1, Name = "Pool View", Occupancy=100, sqt=200 },
              new VillaDTO { Id = 2, Name = "Side View", Occupancy=200, sqt=300 }
        };
    }
}
