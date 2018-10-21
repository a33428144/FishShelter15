using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FishShelter.Models
{
    public class RoomModels
    {
        public RoomModels()
        {
            roomFacilities = new List<string>();
        }
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal people { get; set; }
        public double square { get; set; }
        public int floor { get; set; }
        public string view { get; set; }
        public int photoCount { get; set; }
        public int normalDay { get; set; }
        public int holiDay { get; set; }
        public string url { get; set; }
        public List<string> roomFacilities { get; set; }
    }

    public class RoomDetailModels
    {
        public RoomDetailModels()
        {
            roomFacilities = new List<string>();
        }
        public string subTitle { get; set; }
        public List<string> roomFacilities { get; set; }
    }
}
