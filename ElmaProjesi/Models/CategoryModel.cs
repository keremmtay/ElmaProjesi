using ElmaProjesi.EntityLayer;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ElmaProjesi.WebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Display(Name = "Kategori Adı", Prompt = "Kategori Adını Giriniz")]
        [Required(ErrorMessage = "Kategori Adı zorunlu bir alandır. Boş geçilemez.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Kategori Adı en az 5, en fazla 100 karakter olmalıdır.")]
        public string Name { get; set; }

        [Display(Name = "Kategori Linki", Prompt = "Ürün Linki'ni Giriniz")]
        [Required(ErrorMessage = "Kategori Linki zorunlu bir alandır. Boş geçilemez.")]
        public string Url { get; set; }

        [Display(Name = "Kategori Fotoğrafı", Prompt = "Ürün Fotoğrafı Giriniz")]
        [Required(ErrorMessage = "Kategori Fotoğrafı zorunlu bir alandır. Boş geçilemez.")]
        public string ImageUrl { get; set; }
        //İlişkiler
        public List<SubCategory> SubCategories { get; set; }
    }
}
