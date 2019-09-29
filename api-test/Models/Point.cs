using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace api_test.Models
{
    [DataContract(Name = "point")]
    public class Point
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "phone")]
        public string Phone { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "business_hours")]
        public string BusinessHours { get; set; }
        [DataMember(Name = "lat")]
        public float Lat { get; set; }
        [DataMember(Name = "lon")]
        public float Lon { get; set; }
        [DataMember(Name = "available_categories")]
        public List<Category> AvailableCategories { get; set; }

        [JsonIgnore]
        public static List<Point> MockPoints
        {
            get
            {
                return new List<Point>() {
                    //new Point() { Address="ул.Московская дом 11 а (вход через арку)", Phone = "+7 908 465 26 69", AvailableCategories = new List<Category>() { Category.MockCategories[0],Category.MockCategories[1], Category.MockCategories[2] }, BusinessHours="Сб-Вс, 9:00-14:00", Description = "Шоурум Эковиладж", Lat=52.12, Lon = 23.42 },

                    //new Point() { Address="ул. Московская дом 11а (вход через арку)", Phone = "+79049743082", AvailableCategories = new List<Category>() { Category.MockCategories[0],Category.MockCategories[1], Category.MockCategories[2] }, BusinessHours="Сб-Вс, 9:00-14:00", Description = "Сбор происходит около памятника Ленину", Lat=52.12, Lon = 23.42 },
                    //new Point() { Address="ул. Московская дом 11а (вход через арку)", Phone = "+79519743312", AvailableCategories = new List<Category>() { Category.MockCategories[1], Category.MockCategories[2]   }, BusinessHours="Пн-Вт, 10:00-21:00", Description = "ТРК магазин на первом этаже возле детского мира", Lat=52.12, Lon = 23.42 },
                };
            }
            private set { }
        }
    }
}
