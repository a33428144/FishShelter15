using FishShelter.Models;
using System.Collections.Generic;

namespace FishShelter.Service
{
    public class RoomService
    {
        public List<RoomModels> GetData()
        {
            List<RoomModels> data = new List<RoomModels>();
            data.Add(new RoomModels()
            {
                id = "301",
                name = "海景雙人房",
                people = 2,
                floor = 3,
                normalDay = 3400,
                holiDay = 4000
            });
            data.Add(new RoomModels()
            {
                id = "302",
                name = "海景雙人浴缸房",
                people = 2,
                floor = 3,
                normalDay = 3400,
                holiDay = 4000
            });
            data.Add(new RoomModels()
            {
                id = "303",
                name = "山景四人房",
                people = 4,
                floor = 3,
                normalDay = 3200,
                holiDay = 4200
            });
            data.Add(new RoomModels()
            {
                id = "401",
                name = "海景四人浴缸房",
                people = 4,
                floor = 4,
                normalDay = 3600,
                holiDay = 5000
            });
            data.Add(new RoomModels()
            {
                id = "402",
                name = "山景四人房",
                people = 4,
                floor = 4,
                normalDay = 3600,
                holiDay = 4600
            });
            data.Add(new RoomModels()
            {
                id = "501",
                name = "海景四人浴缸房",
                people = 4,
                floor = 5,
                normalDay = 5000,
                holiDay = 6000
            });
            data.Add(new RoomModels()
            {
                id = "601",
                name = "海景雙人玻璃屋",
                people = 2,
                floor = 6,
                normalDay = 3200,
                holiDay = 4000
            });

            return data;
        }
    }
}
