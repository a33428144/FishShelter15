using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishShelter.Models
{
    public class RoomModels
    {
        public string id { get; set; }
        public string name { get; set; }
        public int people { get; set; }
        public int floor { get; set; }
        public int normalDay { get; set; }
        public int holiDay { get; set; }
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
