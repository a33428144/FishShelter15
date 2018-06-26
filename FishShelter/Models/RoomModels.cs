using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishShelter.Models
{
    public class RoomModels
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class RoomDetailModels
    {
        public RoomDetailModels()
        {
            roomFacilities = new List<string>();
        }
        public int photoCount { get; set; }
        public string subTitle { get; set; }
        public List<string> roomFacilities { get; set; }
    }
}
