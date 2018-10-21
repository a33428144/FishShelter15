﻿using FishShelter.Models;
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
                name = "青春魚礁",
                description = "陽台上小桌小椅坐不住迎面而來的藍，因為是大海！想像戴上草帽赤腳奔跑的場景，陽光、沙灘、刨冰、蜜瓜，享受明媚的景色還有夏休青春之戀的所有元素吧！",
                people = 2,
                square = 7,
                floor = 3,
                view = "海景",
                photoCount = 7,
                normalDay = 2600,
                holiDay = 3000,
                url = "http://bit.ly/2KzfkQc",
                roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "戶外桌椅",
                    "梳妝台"
                }
            });
            data.Add(new RoomModels()
            {
                id = "302",
                name = "美人魚礁",
                description = "偏要做不出門的慵懶美人魚。趴在圓弧形的環景陽台就看到海，隔著玻璃屋泡水的視線，想起從深深海底仰望人類的那一年。一躍而起鑽入潔白被窩，是我在陸地上熱愛的放鬆方式。",
                people = 2,
                square = 7,
                floor = 3,
                view = "海景",
                photoCount = 7,
                normalDay = 2600,
                holiDay = 3000,
                url = "http://bit.ly/2lOyp65",
                roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "泡澡浴缸",
                    "梳妝台"
                }
            });
            data.Add(new RoomModels()
            {
                id = "303",
                name = "離岸魚礁",
                description = "仁者樂山，我樂清淨。從四射的陽光下躲開、從鹹鹹的氣味中躲開、從浪花與浪花之間躲開。出門都是海，進門就是我心屬的靜闊山城，大桌有山林歷史的味道，正好一起喫茶。",
                people = 4,
                square = 7.5,
                floor = 3,
                view = "山景",
                photoCount = 7,
                normalDay = 3000,
                holiDay = 3600,
                url = "http://bit.ly/2tIr1Oe",
                roomFacilities = new List<string>()
                {
                    "木質桌椅"
                }
            });
            data.Add(new RoomModels()
            {
                id = "401",
                name = "堡壘魚礁",
                description = "泡水的地方靠海、發呆的角落一彎、做夢的位置有兩個，有一點光、有一點天空，春天的潮汐和海草是新綠色的，用來養著海洋邊緣一家子的氣泡浮游，剛好足夠。",
                people = 4,
                square = 13,
                floor = 4,
                view = "海景",
                photoCount = 8,
                normalDay = 3600,
                holiDay = 4500,
                url = "http://bit.ly/2tHvcKd",
                roomFacilities = new List<string>()
                {
                    "獨立景觀陽台×2",
                    "泡澡浴缸",
                    "沙發"
                }
            });
            data.Add(new RoomModels()
            {
                id = "402",
                name = "秘密魚礁",
                description = "害羞的人看海，不想被人看到。這裡有草有樹有小小陽台，有山的緩坡和海的彩度，早上不用全員集合起床號，自己爬上高腳椅，獨享從海平面慢慢升上來的一顆紅太陽。",
                people = 4,
                square = 7.8,
                floor = 4,
                view = "山景",
                photoCount = 7,
                normalDay = 3400,
                holiDay = 4300,
                url = "http://bit.ly/2KEs9so",
                roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "搖椅"
                }
            });
            data.Add(new RoomModels()
            {
                id = "501",
                name = "星空魚礁",
                description = "當陣風穿透巨大的魚礁，海洋之歌就被奏響了。向前看是海，向後看是山，花兩個小時向上看夜空，星星或許會掉進來。掉進你的浴缸、你的露台、家人的夢、眾人的海。",
                people = 4,
                square = 18,
                floor = 5,
                view = "海景",
                photoCount = 8,
                normalDay = 4500,
                holiDay = 5100,
                url = "http://bit.ly/2IFqK3g",
                roomFacilities = new List<string>()
                {
                    "私人廣場(含高腳椅)",
                    "獨立景觀陽台×2",
                    "泡澡浴缸",
                    "搖椅",
                    "冰箱",
                    "梳妝台"
                }
            });
            data.Add(new RoomModels()
            {
                id = "601",
                name = "詩人魚礁 ",
                description = "登上山之巔與海水最透明的地方，成為漁村裡的詩人。玻璃架裡有最盛的日光雲彩與蔚藍海流，躺在天空毫無遮掩的正下方，返璞歸真地思考海洋和人真正的樣子。",
                people = 2,
                square = 10,
                floor = 6,
                view = "海景",
                photoCount = 8,
                normalDay = 2700,
                holiDay = 3200,
                url = "http://bit.ly/2IFDW84",
                roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "戶外躺椅×2"
                }
            });

            return data;
        }
    }
}
