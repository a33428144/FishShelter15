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
                name = "海景雙人房"
            });
            data.Add(new RoomModels()
            {
                id = "302",
                name = "海景雙人浴缸房"
            });
            data.Add(new RoomModels()
            {
                id = "303",
                name = "山景四人房"
            });
            data.Add(new RoomModels()
            {
                id = "401",
                name = "海景四人浴缸房"
            });
            data.Add(new RoomModels()
            {
                id = "402",
                name = "山景四人房"
            });
            data.Add(new RoomModels()
            {
                id = "501",
                name = "海景四人浴缸房"
            });

            return data;
        }
    }
}
