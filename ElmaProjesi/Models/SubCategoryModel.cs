using ElmaProjesi.EntityLayer;

namespace ElmaProjesi.WebUI.Models
{
    public class SubCategoryModel
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
