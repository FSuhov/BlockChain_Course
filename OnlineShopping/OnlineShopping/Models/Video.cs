using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public virtual List<User> Users { get; set; }
    }
    public static class ListVideo
    {
        public static List<Video> Videoes()
        {
            var lstVideo = new List<Video> {
                new Video { Id = 1, Title = "How To Become A Millionaire, Step-By-Step", URL = "jfV2CnNQJCg",Image="",Price=3},
                new Video { Id = 2, Title = "Jack Ma - How To Become A Billionaire (MUST WATCH!)", URL = "-JM_bA3EoMo",Image="",Price=2},
                new Video { Id = 3, Title = "TOP SECRET Abandoned Projects You're Not Supposed To Know About!", URL = "HO7mE8Ovju0",Image="",Price=5},
                new Video { Id = 4, Title = "5 Most Top Secret Military Locations", URL = "RqQ0zqyp6_g",Image="",Price=1},
                new Video { Id = 5, Title = "15 Insane Guinness World Records of ALL TIME", URL = "iHSKFgPYySM",Image="",Price=6},
                new Video { Id = 6, Title = "Top 10 Most Dangerous World Records", URL = "QSEwDuKW0Qo",Image="",Price=6}
            };

            return lstVideo;
        }
    }
}
