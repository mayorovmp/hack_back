using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace api_test.Models
{
    [DataContract(Name = "category")]
    public class Category
    {
        [DataMember(Name = "category_id")]
        public int CategoryId { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [JsonIgnore]
        public static List<Category> MockCategories {
            get {
                return new List<Category>() {
                    new Category() { CategoryId = 1, Name = "Бумага" },
                    new Category() { CategoryId = 2, Name = "Стекло" },
                    new Category() { CategoryId = 3, Name = "Батарейки" },
                    new Category() { CategoryId = 4, Name = "Пластик" }
                };
            }
            private set { }
        }
    }
}
