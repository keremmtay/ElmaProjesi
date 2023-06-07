using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class FilterRepository : GenericRepository<Filter, ElmaContext>, IFilterRepository
    {
        public void DeleteFilterFromSubCategories(int filterId, int subCategoriesId)
        {
            throw new NotImplementedException();
        }

        public SubCategory GetByIdWithSubCategories(int filterId)
        {
            throw new NotImplementedException();
        }
    }
}

     new SubCategory() { Name = "Petek Temizliği", Url = "petek-temizligi", ImageUrl = "petektemizligi.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Kombi Tamiri", Url = "kombi-tamiri", ImageUrl = "kombitamiri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Mobilya Montaj", Url = "mobilya-montaji", ImageUrl = "mobilyamontaji.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Çamaşır Makinesi Tamiri", Url = "camasir-makinesi-tamiri", ImageUrl = "camasirmakinesitamiri.jpg", CategoryId="4" },
     new SubCategory() { Name = "Su Kaçağı Tespiti", Url = "su-kacagi-tespiti", ImageUrl = "sukacagitespiti.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Klima Montaj", Url = "klima-montaji", ImageUrl = "klimamontaji.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Kamera Sistemleri", Url = "kamera-sistemleri", ImageUrl = "kamerasistemleri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Elektrik Montaj", Url = "elektrik-montaj", ImageUrl = "elektrikmontaj.jpg", CategoryId = "4" },
     new SubCategory() { Name = "TV LED Değişimi", Url = "tv-led-degisimi", ImageUrl = "tvleddegisimi.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Bulaşık Makinesi Tamiri", Url = "bulasik-makinesi-tamiri", ImageUrl = "bulasikmakinesitamiri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Elektrik Tesisatı", Url = "elektrik-tesisati", ImageUrl = "elektriktesisati.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Elektrik Tamiri", Url = "elektrik-tamiri", ImageUrl = "elektriktamiri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Musluk Tamiri", Url = "musluk-tamiri", ImageUrl = "musluktamiri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Kombi Montaj", Url = "kombi-montaj", ImageUrl = "kombimontaj.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Buzdolabı Tamiri", Url = "buzdolabi-tamiri", ImageUrl = "buzdolabitamiri.jpg", CategoryId = "4" },
     new SubCategory() { Name = "Perde Korniş Takma", Url = "perde-kornis-takma", ImageUrl = "perdekornistakma.jpg", CategoryId = "4" },