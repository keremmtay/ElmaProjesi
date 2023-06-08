using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.EntityLayer
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        //İlişkiler
        public Category Category { get; set; }
        public List<Filter> Filters { get; set; }


    }
}
