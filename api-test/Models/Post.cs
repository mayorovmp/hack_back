using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.Models
{
    public class Post
    {
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int Difficult { get; set; }
    }

    public class PostDetail : Post
    {
        [JsonIgnore]
        public static PostDetail MockPostDetail
        {
            get
            {
                return new PostDetail()
                {
                    Title = "Заголовок о мусоре id = ",
                    SubTitle = "Подзаголовок о мусоре id = ",
                    Difficult = 7,
                    ImgUrl = "https://im7.kommersant.ru/Issues.photo/REGIONS/VRN/2018/132/KNO_004412_00026_1_t218_223339.jpg"

                };
            }
            private set { }
        }

    }
}
