using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace api_test.Models
{
    public class Main
    {
        [DataMember(Name = "categories")]
        public List<Category> Categories { get; set; }
        [DataMember(Name = "points")]
        public List<Point> Points { get; set; }
    }
}
