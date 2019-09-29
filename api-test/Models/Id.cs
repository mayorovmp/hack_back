using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace api_test.Models
{
    public class Id
    {
        [DataMember(Name = "category_id")]
        public int SelectedId { get; set; }
    }
}
