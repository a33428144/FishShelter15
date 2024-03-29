﻿using FishShelter.Models;
using System.Collections.Generic;

namespace FishShelter.Service
{
    public class RoomService
    {
        public List<RoomModels> GetData()
        {
            List<RoomModels> data = new List<RoomModels>
            {
                new RoomModels()
                {
                    id = "301",
                    name = "青春魚礁",
                    description = "陽台上小桌小椅坐不住迎面而來的藍，因為是大海！想像戴上草帽赤腳奔跑的場景，陽光、沙灘、刨冰、蜜瓜，享受明媚的景色還有夏休青春之戀的所有元素吧！",
                    people = 2,
                    floor = 3,
                    square = 7,
                    view = "海景",
                    photoCount = 5,
                    highSeasonNormalDay = 2600,
                    highSeasonHoliDay = 3000,
                    lowSeasonNormalDay = 2200,
                    lowSeasonHoliDay = 2600,
                    yearHoliDay = 3400,
                    summerVacation = 3000,
                    roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "戶外桌椅",
                    "泡澡浴缸",
                    "梳妝台"
                }
                },
                new RoomModels()
                {
                    id = "302",
                    name = "美人魚礁",
                    description = "偏要做不出門的慵懶美人魚。趴在圓弧形的環景陽台就看到海，隔著玻璃屋泡水的視線，想起從深深海底仰望人類的那一年。一躍而起鑽入潔白被窩，是我在陸地上熱愛的放鬆方式。",
                    people = 2,
                    floor = 3,
                    square = 7,
                    view = "海景",
                    photoCount = 5,
                    highSeasonNormalDay = 2600,
                    highSeasonHoliDay = 3000,
                    lowSeasonNormalDay = 2200,
                    lowSeasonHoliDay = 2600,
                    yearHoliDay = 3400,
                    summerVacation = 3000,
                    roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "泡澡浴缸",
                    "梳妝台"
                }
                },
                new RoomModels()
                {
                    id = "303",
                    name = "離岸魚礁",
                    description = "仁者樂山，我樂清淨。從四射的陽光下躲開、從鹹鹹的氣味中躲開、從浪花與浪花之間躲開。出門都是海，進門就是我心屬的靜闊山城，大桌有山林歷史的味道，正好一起喫茶。",
                    people = 4,
                    floor = 3,
                    square = 7.5,
                    view = "山景",
                    photoCount = 5,
                    highSeasonNormalDay = 3000,
                    highSeasonHoliDay = 3600,
                    lowSeasonNormalDay = 3000,
                    lowSeasonHoliDay = 3400,
                    yearHoliDay = 4500,
                    summerVacation = 3600,
                    roomFacilities = new List<string>()
                {
                    "木質桌椅"
                }
                },
                new RoomModels()
                {
                    id = "401",
                    name = "堡壘魚礁",
                    description = "泡水的地方靠海、發呆的角落一彎、做夢的位置有兩個，有一點光、有一點天空，春天的潮汐和海草是新綠色的，用來養著海洋邊緣一家子的氣泡浮游，剛好足夠。",
                    people = 4,
                    floor = 4,
                    square = 13,
                    view = "海景",
                    photoCount = 8,
                    highSeasonNormalDay = 3600,
                    highSeasonHoliDay = 4500,
                    lowSeasonNormalDay = 3400,
                    lowSeasonHoliDay = 4000,
                    yearHoliDay = 5200,
                    summerVacation = 4500,
                    roomFacilities = new List<string>()
                {
                    "獨立景觀陽台×2",
                    "泡澡浴缸",
                    "沙發"
                }
                },
                new RoomModels()
                {
                    id = "402",
                    name = "秘密魚礁",
                    description = "害羞的人看海，不想被人看到。這裡有草有樹有小小陽台，有山的緩坡和海的彩度，早上不用全員集合起床號，自己爬上高腳椅，獨享從海平面慢慢升上來的一顆紅太陽。",
                    people = 2,
                    floor = 4,
                    square = 8,
                    view = "山景",
                    photoCount = 6,
                    highSeasonNormalDay = 2800,
                    highSeasonHoliDay = 3200,
                    lowSeasonNormalDay = 3200,
                    lowSeasonHoliDay = 3600,
                    yearHoliDay = 3800,
                    summerVacation = 3200,
                    roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "搖椅"
                }
                },
                new RoomModels()
                {
                    id = "501",
                    name = "星空魚礁",
                    description = "當陣風穿透巨大的魚礁，海洋之歌就被奏響了。向前看是海，向後看是山，花兩個小時向上看夜空，星星或許會掉進來。掉進你的浴缸、你的露台、家人的夢、眾人的海。",
                    people = 4,
                    floor = 5,
                    square = 12,
                    view = "山景、海景",
                    photoCount = 5,
                    highSeasonNormalDay = 3600,
                    highSeasonHoliDay = 4500,
                    lowSeasonNormalDay = 3400,
                    lowSeasonHoliDay = 4000,
                    yearHoliDay = 5000,
                    summerVacation = 4500,
                    roomFacilities = new List<string>()
                {
                    "景觀陽台",
                    "泡澡浴缸",
                    "搖椅",
                    "冰箱",
                    "梳妝台"
                }
                },
                new RoomModels()
                {
                    id = "502",
                    name = "珊海魚礁",
                    description = "當陣風穿透巨大的魚礁，海洋之歌就被奏響了。向前看是海，向後看是山，花兩個小時向上看夜空，星星或許會掉進來。掉進你的浴缸、家人的夢、珊瑚的海。",
                    people = 3,
                    floor = 5,
                    square = 8,
                    view = "山景、海景",
                    photoCount = 5,
                    highSeasonNormalDay = 3400,
                    highSeasonHoliDay = 4200,
                    lowSeasonNormalDay = 3200,
                    lowSeasonHoliDay = 3600,
                    yearHoliDay = 4700,
                    summerVacation = 4200,
                    roomFacilities = new List<string>()
                {
                    "泡澡浴缸",
                    "冰箱",
                    "梳妝台"
                }
                },
                new RoomModels()
                {
                    id = "601",
                    name = "詩人魚礁",
                    description = "登上山之巔與海水最透明的地方，成為漁村裡的詩人。玻璃架裡有最盛的日光雲彩與蔚藍海流，躺在天空毫無遮掩的正下方，返璞歸真地思考海洋和人真正的樣子。",
                    people = 2,
                    floor = 6,
                    square = 10,
                    view = "海景",
                    photoCount = 4,
                    highSeasonNormalDay = 2700,
                    highSeasonHoliDay = 3200,
                    lowSeasonNormalDay = 2500,
                    lowSeasonHoliDay = 2800,
                    yearHoliDay = 3600,
                    summerVacation = 3200,
                    roomFacilities = new List<string>()
                {
                    "獨立景觀陽台",
                    "戶外躺椅×2"
                }
                }
            };

            return data;
        }
    }
}
