using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_test.Models
{
    public class Tape
    {
        public List<Story> Stories { get; set; }
        public List<Post> Posts { get; set; }

        [JsonIgnore]
        public static Tape MockTape
        {
            get
            {
                return new Tape()
                {
                    Stories = new List<Story>() {
                    new Story() {
                        ImgUrl = "https://ichef.bbci.co.uk/news/976/cpsprodpb/128C3/production/_103617957_screenshot2018-09-27at17.58.56.png", Preview= "http://icons.iconarchive.com/icons/iconsmind/outline/256/Preview-icon.png" },
                    new Story() {
                        ImgUrl = "https://ichef.bbci.co.uk/news/976/cpsprodpb/128C3/production/_103617957_screenshot2018-09-27at17.58.56.png", Preview= "http://icons.iconarchive.com/icons/iconsmind/outline/256/Preview-icon.png" }},
                    Posts = new List<Post>() {
                    new Post()
                    {
                        Title = "Заголовок о мусоре 1",
                        SubTitle = "Подзаголовок о мусоре 1",
                        Difficult = 7,
                        ImgUrl = "https://im7.kommersant.ru/Issues.photo/REGIONS/VRN/2018/132/KNO_004412_00026_1_t218_223339.jpg"
                    },
                    new Post()
                    {
                        Title = "Заголовок о мусоре 2",
                        SubTitle = "Подзаголовок о мусоре 2",
                        Difficult = 3,
                        ImgUrl = "https://im7.kommersant.ru/Issues.photo/REGIONS/VRN/2018/132/KNO_004412_00026_1_t218_223339.jpg"
                    }
                }
                };
            }
            private set { }
        }
    }
}
