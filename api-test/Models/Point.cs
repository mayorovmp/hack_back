﻿using Newtonsoft.Json;
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
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "business_hours")]
        public string BusinessHours { get; set; }

        [DataMember(Name = "lat")]
        public double Lat { get; set; }
        [DataMember(Name = "lon")]
        public double Lon { get; set; }
        [DataMember(Name = "available_categories")]
        public List<Category> AvailableCategories { get; set; }

        [JsonIgnore]
        public static List<Point> MockPoints
        {
            get
            {
                return new List<Point>() {
                    new Point() { AvailableCategories = new List<Category>() { Category.MockCategories[0] }, BusinessHours="Сб-Вс, 9:00-14:00", Description = "Сбор происходит около памятника Ленину", Lat=52.12, Lon = 23.42 },
                    new Point() { AvailableCategories = new List<Category>() { Category.MockCategories[1], Category.MockCategories[2]   }, BusinessHours="Пн-Вт, 10:00-21:00", Description = "ТРК магазин на первом этаже возле детского мира", Lat=52.12, Lon = 23.42 },
                };
            }
            private set { }
        }
    }
}