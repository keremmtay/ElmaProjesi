using ElmaProjesi.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElmaProjesi.DataAccessLayer.Concrete
{
    public class MyInitialData
    {
        private static Category[] Categories = new Category[]
        {
            new Category() {Name="Temizlik",Url="temizlik", ImageUrl="temizlik.jpg", SubCategories = new List<SubCategory>() {
                new SubCategory() {Name="Ev Temizliği", Url="ev-temizligi", ImageUrl="ev-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç Oda?" }, new Filter  {Question="Kaç Banyo?" }, new Filter {Question="Temizlik Kaç Saat Yapılsın?"}, new Filter{ Question="Evde köpek veya kedi var mı?"}, new Filter() { Question = "Ayrıntılar" }, new Filter() { Question = "Adres" }, new Filter() { Question = "Tarih" } }
                    },
                new SubCategory() {Name="Boş Ev Temizliği", Url="bos-ev-temizligi", ImageUrl="bos-ev-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç Oda?" },new Filter  {Question="Kaç Banyo?" }, new Filter  {Question="Ev hangi sebepten dolayı boş?" }, new Filter  {Question="Ayrıntılar" }, new Filter  {Question="Adres"}, new Filter  {Question="Tarih" },}},
                new SubCategory() {Name="Koltuk Yıkama", Url="koltuk-yikama", ImageUrl="koltuk-yikama.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç halı yıkanacak? " },new Filter() { Question="Koltuklar minderli mi?" }, new Filter() { Question="Sandalye yıkanacaksa kaç adet? " }, new Filter() { Question="Yatak yıkanacaksa kaç adet yıkanacak? " }, new Filter() { Question="Ayrıntılar " },new Filter() { Question="Adres" },new Filter() { Question="Tarih" },}},
                new SubCategory() {Name="Halı Yıkama", Url="hali-temizligi", ImageUrl="hali-temizligi.jpeg",Filters = new List<Filter>(){ new Filter() { Question="Halı nerede yıkansın?" }, new Filter() { Question = "Kaç metrekare yıkanacak?" }, new Filter() { Question = "Çıkarılmasını istediğin lekeler var mı?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Adres" }}},
                new SubCategory() {Name="İnşaat Sonrası Temizlik", Url="insaat-sonrasi-temizlik", ImageUrl="insaat-sonrasi-temizlik.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç oda?" }, new Filter() { Question="Kaç banyo?" }, new Filter() { Question="Kaç metrekare temizlenecek?" }, new Filter() { Question="Evin durumu nedir?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Apartman Temizliği", Url="apartman-temizligi", ImageUrl="apartman-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Apartman(lar)da toplam kaç daire var?" }, new Filter() { Question="Çöp toplanmasını istiyor musunuz?" }, new Filter() { Question="Temizlik sıklığı nasıl olsun?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Ofis Temizliği", Url="ofis-temizligi", ImageUrl="ofis-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Hangi sıklıkla yapılsın?" }, new Filter() { Question="Ofis temizliğine neler dahil olsun?" }, new Filter() { Question="Temizlenecek alan kaç metrekare?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Haşere İlaçlama", Url="hasere-ilaclama", ImageUrl="hasere-ilaclama.jpg", Filters = new List<Filter>(){ new Filter() { Question="Haşare tipi nedir?" }, new Filter() { Question="Kaç metrekare alan ilaçlanacak?" }, new Filter() { Question="Mekan tipi nedir?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Cam Temizliği", Url="cam-temizligi", ImageUrl="cam-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Camları temizlenecek mekan nedir?" }, new Filter() { Question="Evde hangi tip balkon var?" }, new Filter() { Question="Dıç cephe camı temizlenecek bina kaç katlı?" }, new Filter() { Question="Temizlenecek mağaza camı kaç metrekare?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Evde Ütü Hizmeti", Url="evde-utu-hizmeti", ImageUrl="evde-utu-hizmeti.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç tane küçük parça ütülenecek?" }, new Filter() { Question="Kaç tane orta boy parça ütülenecek?" }, new Filter() { Question= "Kaç tane büyük boy parça ütülenecek?" }, new Filter() { Question="Ütü hangi sıklıkla yapılsın?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" } }},
                new SubCategory() {Name="Böcek İlaçlama", Url="bocek-ilaclama", ImageUrl="bocek-ilaclama.jpg", Filters = new List<Filter>(){ new Filter() { Question="Böcek tipi nedir?" }, new Filter() { Question="İlaçlanacak bölge tipi nedir?" }, new Filter() { Question="Kaç metrekare alan ilaçlanacak? " }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Yatak Yıkama", Url="yatak-yikama", ImageUrl="yatak-yikama.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç adet yatak yıkanacak?" }, new Filter() { Question="Yatağın büyüklüğü nedir?" }, new Filter() { Question="Çıkarılmasını istediğin lekeler var mı?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Evde Yemek Pişirme", Url="evde-yemek-pisirme", ImageUrl="evde-yemek-pisirme.jpg", Filters = new List<Filter>(){ new Filter() { Question="Kaç kişilik yemek pişirilmesini istiyorsun?" }, new Filter() { Question="Kaç çeşit yemek pişirilmesini istiyorsun?" }, new Filter() { Question="Hangi sıklıkla pişirilmesini istiyorsun" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Tahta Kurusu İlaçlama", Url="tahta-kurusu-ilaclama", ImageUrl="tahta-kurusu-ilaclama.jpg", Filters = new List<Filter>(){ new Filter() { Question="Toplam kaç metrekare alan ilaçlanacak?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Dükkan Temizliği", Url="dukkan-temizligi", ImageUrl="dukkan-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question="Temizlenecek dükkan kaç metrekare?" }, new Filter() { Question="Hangi sıklıkla temizlenmesini istiyorsun?" }, new Filter() { Question="Temizliğe neler dahil olsun?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}}
                } },
            new Category() {Name="Tadilat", Url="tadilat", ImageUrl="tadilat.jpg", SubCategories=new List<SubCategory>(){
                new SubCategory() {Name="Boya Badana", Url="boya-badana", ImageUrl="boya-badana.jpg",Filters = new List<Filter>(){ new Filter() { Question= "Kaç metrekare oda/ev boyanacak?" }, new Filter() { Question = "Bu alan kaç oda?" }, new Filter() { Question = "Fiyata malzeme dahil olsun mu?" }, new Filter() { Question = "Boya badana yapılacak alan eşyalı mı?" }, new Filter() { Question = "Tavanlar Boyanacak mı?" }, new Filter() { Question = "Boyacı başka neyi bilmeli?" }, new Filter() { Question = "Nerede boya badana yapılacak il, ilçe ,mahalle" }, new Filter() { Question = "Ne zaman?" }, } },
                new SubCategory() {Name="Ev Tadilat", Url="ev-tadilat", ImageUrl="ev-tadilat.jpg",Filters = new List<Filter>(){ new Filter() { Question= "Ne yapılması Gerekiyor?" }, new Filter() { Question= "Ne yapılmasını istiyorsun?" },new Filter() { Question= "Hangi tadilat yapılacak" },new Filter() { Question= "Kaç metre kare" },new Filter() { Question= "Nerde?" },new Filter() { Question= "Ne zaman?" }, }},
                new SubCategory() {Name="Mutfak Dolabı Yapımı", Url="mutfak-dolabi-yapimi", ImageUrl="mutfak-dolabi-yapimi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Hangi tip Mutfak dolabı yapımı istiyorsunuz?" },new Filter() { Question= "Toplam dolap uzunluğu kaç metre olacak?" },new Filter() { Question= "Kapak kaplaması için malzeme tercihi var mı?" },new Filter() { Question= "Dolap gövdesi için malzeme tercihi var mı?" },new Filter() { Question= "İhtiyaç detayları nelerdir?" },new Filter() { Question= "Nerde?" },new Filter() { Question= "Ne zaman?" }, }},
                new SubCategory() {Name="Cam Balkon", Url="cam-balkon", ImageUrl="cam-balkon.jpg" , Filters = new List<Filter>(){ new Filter() { Question= "Cam Balkon sistemi nasıl olsun" }, new Filter() { Question= "Balkon cam ile kapatılacak kenar uzunluğu çevresi kaç metre?" },new Filter() { Question= "Cam yüksekliği kaç metre olacak?" },new Filter() { Question= "Balkon şekli nasıl? (Kaç cephe kapatılacak?)" }, new Filter() { Question= "Cam tercihi var mı?" },new Filter() { Question= "İhtiyaç detayları nelerdir?" },new Filter() { Question= "Nerde ?" },new Filter() { Question= "Ne zaman?" }, }},

                new SubCategory() {Name="Fayans Döşeme", Url="fayans-doseme", ImageUrl="fayans-doseme.jpg",Filters = new List<Filter>(){ new Filter() { Question= "Fayans Döşenecek alan kaç metrekare?" }, new Filter() { Question= "Fayans döşeme dışında başka bir iş var mı?" }, new Filter() { Question= "Fiyata fayans malzemesi dahil olsun mu?" }, new Filter() { Question= "Kırılacak mevcut fayans var mı*" }, new Filter() { Question= "İhtiyaç detayları nelerdir?" }, new Filter() { Question= "Nerde ?" }, new Filter() { Question= "Ne zaman?" } }},

                new SubCategory() {Name="Banyo Tadilatı", Url="banyo-tadilatı", ImageUrl="banyo-tadilatı.jpg" ,Filters = new List<Filter>(){ new Filter() { Question= "Ne yapılmasını istiyorsunuz?" }, new Filter() { Question= "Banyoda hangi tadilat yapılacak" },new Filter() { Question= "Kaç metre banyo alanı tadilat Yapılacak?" }, new Filter() { Question= "Fiyata malzeme dahil olsun mu?" },new Filter() { Question= "İhtiyaç detayları nelerdir?" },new Filter() { Question= "Nerde ?" },new Filter() { Question= "Ne zaman?" },}},

                new SubCategory() {Name="Anahtar Teslim İnşaat", Url="anahtar-teslim-insaat", ImageUrl="anahtar-teslim-insaat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç kat inşa edilecek?" }, new Filter() { Question = "Binada kaç daire olacak" }, new Filter() { Question = "Proje çizimleri hazır mı?" }, new Filter() { Question = "Ödeme tercihiniz nedir" }, new Filter() { Question = "Bina tipi yapı malzemesi ne olacak?" }, new Filter() { Question = "Malzeme kalitesi tercihi var mı?" }, new Filter() { Question = "Bina taban alanı kaç metrekare?" }, new Filter() { Question = "Arsa ne durumda?" }, new Filter() { Question = "Arsanın imar izni var mı?" }, new Filter() { Question = "Proje detayları neler?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }, }},

                new SubCategory() {Name="Parke Laminant Döşeme", Url="parke-laminant-doseme", ImageUrl="parke-laminant-doseme.jpg", Filters = new List < Filter >() { new Filter() { Question = "Parke döşenecek alan kaç metrekare?" }, new Filter() { Question = "Fiyata malzeme dahil olsun mu?" }, new Filter() { Question = "Parke döşeme haricinde yaptırmak istediğiniz başka işlem var mı?" }, new Filter() { Question = "Parke döşencek alan eşyalı mı olacak?" }, new Filter() { Question = "İhtiyaç detayları nelerdir?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }, }},

                new SubCategory() {Name="Deprem Testi", Url="deprem-testi", ImageUrl="deprem-testi.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç adet bina/blok için deprem testi yapılacak?" },  new Filter() { Question = "binalar kaç katlı" },  new Filter() { Question = "Bina zemin oturum alanı kaç metrekare?" },  new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }, }},

                new SubCategory() {Name="Mantolama", Url="mantolama", ImageUrl="mantolama.jpg", Filters = new List < Filter >() { new Filter() { Question = "Mantolama yapılacak bina kaç katlı?" }, new Filter() { Question = "Bina uzun cephesi kaç metre? (kat metrekare hesabı için)" },new Filter() { Question = "Kısa cephesi kaç metre?" },new Filter() { Question = "Bu özelliklerden hangileri isteniyor?" },new Filter() { Question = "Malzeme markası tercihi var mı?" }, new Filter() { Question = "Balkon tipi nedir?" }, new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }, }},

                new SubCategory() {Name="Duşakabin", Url="dusakabın", ImageUrl="dusakabın.jpg", Filters = new List < Filter >() { new Filter() { Question = "Neye ihtiyacın var?" },new Filter() { Question = "Kaç adet duşakabin?" },new Filter() { Question = "Duşakabin ölçüleri ne kadar?" },new Filter() { Question = "Montajı yapılacak duşakabin tipi nedir?" },new Filter() { Question = "Eski duşakabin sökülecek mi?" }, new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" },}},

                new SubCategory() {Name="Anahtar Teslim Tadilat", Url="anahtar-teslim-tadilat", ImageUrl="anahtar-teslim-tadilat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangisine ihtiyacınız var?" },new Filter() { Question = "Tadilat yapılacak alan kaç metrekare?" },new Filter() { Question = "Hangi tadilat işleri yapılacak?" },new Filter() { Question = "Hangi odalarda tadilat yapılacak?" },new Filter() { Question = "Bütçe yaklaşık kaç TL?" },new Filter() { Question = "Malzeme kalitesi tercihi var mı?" },new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" } }},

                new SubCategory() {Name="Prefabrik Ev Yapımı", Url="prefabrik-ev-yapimi", ImageUrl="prefabrik-ev-yapimi.jpg", Filters = new List < Filter >() { new Filter() { Question = "Büyüklüğü kaç metrekare olmalı?" },new Filter() { Question = "Kaç katlı olacak?" },new Filter() { Question = "Subasman yapımı (temel betonu) fiyata dahil olsun mu?" },new Filter() { Question = "Prefabrik evi yapacak firma başka neleri bilmeli?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" } }},

                new SubCategory() {Name="Alçıpan Asma Tavan", Url="alcipan-asma-tavan", ImageUrl="alcipan-asma-tavan.jpg", Filters = new List < Filter >() { new Filter() { Question = "Toplam kaç metrekare asma tavan yapılacak?" }, new Filter() { Question = "Hangi ekstra hizmetler yapılacak?" }, new Filter() { Question = "Fiyata malzeme dahil olsun mu?" }, new Filter() { Question = "İhtiyacın detayları neler?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }  }},

                new SubCategory() {Name="Koltuk Döşeme", Url="koltuk-doseme", ImageUrl="koltuk-doseme.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangi tip koltuk döşeme istiyorsun?" }, new Filter() { Question = "Kaç adet L koltuk kaplanacak?" },new Filter() { Question = "Nasıl bir döşeme istiyorsun?" },new Filter() { Question = "Kaç adet yastık veya kırlent?" },new Filter() { Question = "Fotoğraf ekleme kister misin?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" } }},

                new SubCategory() {Name="İç Mimar", Url="ic-mimar", ImageUrl="ic-mimar.jpg", Filters = new List < Filter >() { new Filter() { Question = "İç mimarlık yapılacak mekan neresi?" }, new Filter() { Question = "Ne yapılması gerekiyor?" },new Filter() { Question = "İç mimarlık gereken alan kaç metrekare?" },new Filter() { Question = "Hangi tadilat işleri yapılacak?" },new Filter() { Question = "Malzeme kalitesi tercihi var mı?" },new Filter() { Question = "Bütçe yaklaşık kaç TL?" },new Filter() { Question = "Keşif için ne zaman uygun olur?" },new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }}},

                new SubCategory() {Name="Mutfak Tadilat", Url="mutfak-tadilat", ImageUrl="mutfak-tadilat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Ne yapılmasını istiyorsun?" }, new Filter() { Question = "Boyanacak dolap(lar) kaç kapaklı?" },new Filter() { Question = "Boyanacak dolap(lar)ın toplam uzunluğu kaç metre?" }, new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" } }},

                new SubCategory() {Name="Havuz Yapımı", Url="havuz-yapimi", ImageUrl="havuz-yapimi.jpg", Filters = new List < Filter >() { new Filter() { Question = "Ne tür bir havuz istiyorsun?" }, new Filter() { Question = "Havuz boyu (uzun kenarı) kaç metre olacak?" },new Filter() { Question = "Havuz eni (kısa kenarı) kaç metre olacak?" },new Filter() { Question = "Havuz derinliği kaç metre olacak?" },new Filter() { Question = "Fiyata hafriyat dahil olsun mu?" },new Filter() { Question = "İstediğin yüzme havuzunun detayları neler?" }, new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" } }},

                new SubCategory() {Name="Gardrop Yapımı", Url="gardrop-yapimi", ImageUrl="gardrop-yapimi.jpg", Filters = new List < Filter >() { new Filter() { Question = "Yaptırmak istediğin gardrobun genişliği (eni) kaç cm olacak?" }, new Filter() { Question = "Yüksekliği (boyu) kaç cm?" }, new Filter() { Question = "Derinliği kaç cm?" },new Filter() { Question = "Gardrop kapısı tipi tercihiniz nedir?" },  new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }}},

                new SubCategory() {Name="İç Mimari Çizim", Url="ic-mimar-cizim", ImageUrl="ic-mimar-cizim.jpg", Filters = new List < Filter >() { new Filter() { Question = "Çizimi yapılacak proje nedir?" }, new Filter() { Question = "Çizimi yapılacak proje alanı kaç metrekare?" },    new Filter() { Question = "İhtiyacın detayları neler?" },  new Filter() { Question = "Nerde?" }, new Filter() { Question = "Ne zaman?" }}}
                } },
            new Category() {Name="Nakliyat",Url="nakliyat", ImageUrl="nakliyat.jpg",SubCategories=new List<SubCategory>(){
                 new SubCategory() { Name = "Evden Eve Nakliyat", Url = "evden-eve-nakliyat", ImageUrl = "evden-eve-nakliyat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç odali ev taşınacak?" }, new Filter() { Question= "Kaç kat taşınacak ?" }, new Filter() { Question= "Eski ev nerede?" }, new Filter() { Question= "Yeni ev nerede?" }, new Filter() { Question= "Ne zaman ?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Şehirler Arası Nakliye", Url = "sehirler-arasi-nakliye", ImageUrl = "sehirler-arasi-nakliye.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç odali ev taşınacak?" }, new Filter() { Question= "Taşınacak yükün ağırlığı" }, new Filter() { Question= "Taşınacak yük nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Eşya Taşıma", Url = "esya-tasima", ImageUrl = "esya-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Eşyaların ağırlığı nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Eşya Depolama", Url = "esya-depolama", ImageUrl = "esya-depolama.jpg", Filters = new List < Filter >() { new Filter() { Question = "Ne kadar eşya depolanacak?" }, new Filter() { Question= "Eşyalar ne kadar süre depolanacak ?" }, new Filter() { Question= "Nakliye hizmete dahil olsun mu ?" }, new Filter() { Question= "Depolanacak eşya nerede ?" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" }  }},
                new SubCategory() { Name = "Şehirler Arası Eşya Taşıma", Url = "sehirler-arasi-esya-tasima", ImageUrl = "sehirler-arasi-esya-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Eşyaların ağırlığı nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" }  }},
                new SubCategory() { Name = "Şehir İçi Nakliye", Url = "sehir-ici-nakliye", ImageUrl = "sehir-ici-nakliye.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç odali ev taşınacak?" }, new Filter() { Question= "Taşınacak yükün ağırlığı" }, new Filter() { Question= "Taşınacak yük nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Asansörlü Nakliyat", Url = "asansorlu-nakliyat", ImageUrl = "asansorlu-nakliyat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç odali ev eşyası taşınacak?" }, new Filter() { Question= "Eski evden eşya nasıl taşınacak?" }, new Filter() { Question= "Yeni eve eşya nasıl taşınacak?" }, new Filter() { Question= "Eski ev nerede?" }, new Filter() { Question= "Ne zaman ?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Hamal", Url = "hamal", ImageUrl = "hamal.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç adet büyük eşya taşınacak ?" }, new Filter() { Question= "Kaç adet koli taşınacak ?" }, new Filter() { Question= "Eşyalar kaçıncı kattan alınacak ?" }, new Filter() { Question= "Eşyalar kaçıncı kata taşınacak ?" }, new Filter() { Question= "Nasıl taşınacak ?" }, new Filter() { Question= "Kaç kişiye ihtiyaç var ?" }, new Filter() { Question= "Nerede?" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Havaalanı Transfer", Url = "havaalani-transfer", ImageUrl = "havaalani-transfer.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangi havaalanı ?" }, new Filter() { Question= "Gidiş dönüş mü tek yön mü ?" }, new Filter() { Question= "Kaç kişi ?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Yük Taşıma", Url = "yuk-tasima", ImageUrl = "yuk-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangisine ihtiyacım var ?" }, new Filter() { Question= "Taşınacak yükün ağırlığı ?" }, new Filter() { Question= "Taşınacak yük nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Ev Taşıma", Url = "ev-tasima", ImageUrl = "ev-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç odali ev taşınacak?" }, new Filter() { Question= "Kaç kat taşınacak ?" }, new Filter() { Question= "Eski ev nerede?" }, new Filter() { Question= "Yeni ev nerede?" }, new Filter() { Question= "Ne zaman ?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Uluslararası Evden Eve Nakliyat", Url = "uluslararasi-evden-eve-nakliyat", ImageUrl = "uluslararasi-evden-eve-nakliyat.jpg", Filters = new List < Filter >() { new Filter() { Question = "Taşınacak eşyaların hacmi kaç metreküp ?" }, new Filter() { Question= "Hangi ülkeden ?" }, new Filter() { Question= "Hangi ülkeye ?" }, new Filter() { Question= "Ne zaman ?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Şehirler Arası Yük Taşıma", Url = "sehirler-arasi-yuk-tasima", ImageUrl = "sehirler-arasi-yuk-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangisine ihtiyacım var ?" }, new Filter() { Question= "Taşınacak yükün ağırlığı ?" }, new Filter() { Question= "Taşınacak yük nedir?" }, new Filter() { Question= "Alınacak yer" }, new Filter() { Question= "Varış yeri" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }},
                new SubCategory() { Name = "Motosiklet Taşıma", Url = "motosiklet-tasima", ImageUrl = "motosiklet-tasima.jpg", Filters = new List < Filter >() { new Filter() { Question = "Taşınacak motosiklet türü nedir ?" }, new Filter() { Question= "Motosiklet nereden alınacak ?" }, new Filter() { Question= "Nereye taşınacak ?" }, new Filter() { Question= "Ne zaman?" }, new Filter() { Question= "Açıklama" } }}
                } },
            new Category() {Name="Tamir", Url="tamir", ImageUrl="tamir.jpg", SubCategories = new List<SubCategory>(){
                new SubCategory() { Name = "Petek Temizliği", Url = "petek-temizligi", ImageUrl = "petek-temizligi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Kaç Adet Petek?" }, new Filter() {Question = "Kombi Bakımı Yapılsın MI?" }, new Filter() {Question = "Detayları yazın." } } },
                new SubCategory() { Name = "Kombi Tamiri", Url = "kombi-tamiri", ImageUrl = "kombi-tamiri.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Arızayı Tanımlayın" }, new Filter() {Question = "Kombi Markası?" }, new Filter() { Question = "Detayları yazın." } } },
                new SubCategory() { Name = "Mobilya Montaj", Url = "mobilya-montaji", ImageUrl = "mobilya-montaji.jpg", Filters = new List < Filter >() { new Filter() { Question = "Mobilya Ustası Ne Yapmalı?" }, new Filter() {Question= "Neyin Montaja ihtiyacı var" }, new Filter() {Question= "Taşınacak mı?" } }},
                new SubCategory() { Name = "Çamaşır Makinesi Tamiri", Url = "camasir-makinesi-tamiri", ImageUrl ="camasir-makinesi-tamiri.jpg" , Filters = new List < Filter >() { new Filter() { Question = "Arıza Nedir?" }, new Filter() {Question = "Markası?" }, new Filter() {Question = "Detayları Yazın." } }},
                new SubCategory() { Name = "Su Kaçağı Tespiti", Url = "su-kacagi-tespiti", ImageUrl = "su-kacagi-tespiti.jpg", Filters = new List < Filter >() { new Filter() { Question = "Sorun Nedir?" }, new Filter() {Question = "Sorunun Nerden Geldiğini Biliyor Musunuz?" }, new Filter() { Question= "Tamir ister misiniz?" }, new Filter() {Question = "Detayları yazın." } }},
                new SubCategory() { Name = "Klima Montaj", Url = "klima-montaji", ImageUrl = "klima-montaji.jpg" , Filters = new List < Filter >() { new Filter() { Question = "Ne yapılacak?" }, new Filter() {Question= "Kaç adet klima var?" }, new Filter() {Question= "Klima kaç BTU?" }, new Filter() { Question= "Detayları yazın." } }},
                new SubCategory() { Name = "Kamera Sistemleri", Url = "kamera-sistemleri", ImageUrl = "kamera-sistemleri.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangisine ihtiyacın var?" }, new Filter() { Question= "Kaç adet kamera?" }, new Filter() { Question= "Detayları yazın." } }},
                new SubCategory() { Name = "Elektrik Montaj", Url = "elektrik-montaj", ImageUrl = "elektrik-montaj.jpg", Filters = new List < Filter >() { new Filter() { Question = "Hangi ürünler takılacak?" }, new Filter() { Question= "Kaç ürün takılacak?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "TV LED Değişimi", Url = "tv-led-degisimi", ImageUrl = "tv-led-degisimi.jpg", Filters = new List < Filter >() { new Filter() { Question = "TV kaç ekran?" }, new Filter() { Question= "TV Markası?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Bulaşık Makinesi Tamiri", Url = "bulasik-makinesi-tamiri", ImageUrl ="bulasik-makinesi-tamiri.jpg", Filters = new List < Filter >() { new Filter() { Question = "Arızası Nedir?" }, new Filter() { Question= "Markası Nedir?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Elektrik Tesisatı", Url = "elektrik-tesisati", ImageUrl = "elektrik-tesisati.jpg", Filters = new List < Filter >() { new Filter() { Question = "Neresi yenilecek?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Elektrik Tamiri", Url = "elektrik-tamiri", ImageUrl = "elektrik-tamiri.jpg", Filters = new List < Filter >() { new Filter() { Question = "Arıza ne ile ilgili?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Musluk Tamiri", Url = "musluk-tamiri", ImageUrl = "musluk-tamiri.jpg", Filters = new List < Filter >() { new Filter() { Question = "Arıza ne ile ilgili?" },new Filter() { Question= "Hangi musluklar?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Kombi Montaj", Url = "kombi-montaj", ImageUrl = "kombi-montaj.jpg", Filters = new List < Filter >() { new Filter() { Question = "Montaj hariç neler yapılacak?" }, new Filter() { Question= "Kaç adet petek takılacak?" }, new Filter() { Question= "Fiyata malzeme (kombi, petek) dahil olsun mu?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Buzdolabı Tamiri", Url = "buzdolabi-tamiri", ImageUrl = "buzdolabi-tamiri.jpg", Filters = new List < Filter >() { new Filter() { Question = "Arıza ne ile ilgili?" },new Filter() { Question= "Markası nedir?" }, new Filter() { Question= "Detaylarını yazın." } }},
                new SubCategory() { Name = "Perde Korniş Takma", Url = "perde-kornis-takma", ImageUrl = "perde-kornis-takma.jpg", Filters = new List < Filter >() { new Filter() { Question = "Kaç adet takılacak?" },new Filter() { Question= "Toplam kaç metre korniş takılacak?" },new Filter() { Question= "Nereye takılacak?" }, new Filter() { Question= "Detaylarını yazın." } }},
                } },
            new Category() {Name="Özel Ders", Url="ozel-ders", ImageUrl="ozel-ders.jpg", SubCategories=new List<SubCategory>(){
                new SubCategory() {Name="Direksiyon Dersi", Url="direksiyon-dersi", ImageUrl="direksiyon-dersi.jpg",
                    Filters = new List<Filter>() {
                        new Filter() {Question="Eğitmen aracı ile"},
                        new Filter() {Question="Kendi aracım ile"},
                        new Filter() {Question="Eğitmenin cinsiyet tercihi"},
                        new Filter() {Question="Ehliyetin var mı"},
                        new Filter() {Question="Vites tercihin"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"},
                        new Filter() {Question="Hizmetin verileceği yer"}
                    }} ,
                new SubCategory() {Name="Online İngilizce Özel Ders", Url="online-ingilizce-ozel-ders", ImageUrl="online-ingilizce-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersi alacak kişi okula gidiyor mu"},
                        new Filter() {Question="Amacı nedir(TOFL, YDS) vs"},
                        new Filter() {Question="Hangi seviyede"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="İngilizce Özel Ders", Url="ingilizce-ozel-ders", ImageUrl="ingilizce-ozel-ders.jpg",
                Filters = new List<Filter>()
                {
                    new Filter() {Question="Dersin yapılacağı yer(zoom/ev)"},
                    new Filter() {Question="Dersi alacak kişi okula gidiyor mu"},
                    new Filter() {Question="Amacı nedir(TOFL, YDS) vs"},
                    new Filter() {Question="Hangi seviyede"},
                    new Filter() {Question="Hangi sıklıkta ay/hafta"},
                    new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                }},
                new SubCategory() {Name="İlkokul Özel Ders", Url="ilkokul-ozel-ders", ImageUrl="ilkokul-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacağı yer(zoom/ev)"},
                        new Filter() {Question="Hangi derslerde özel ders almak istiyorsun"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Kaçıncı sınıf öğrencisi ders almak istiyorsun"},
                        new Filter() {Question="ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Ortaokul Matematk Özel Ders", Url="ortaokul-matematik-ozel-ders", ImageUrl="ortaokul-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacağı yer(zoom/ev)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçıncı sınıfa gidiyor"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Yüzme Dersi", Url="yuzme-dersi", ImageUrl="yuzme-dersi.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerde yapılsın(eğitmenin yerinde veya benim önerdiğim yerde)"},
                        new Filter() {Question="Yüzme eğitmeninin cinsiyet tercihi"},
                        new Filter() {Question="Dersi alacak kişi(ler) kaç yaşında"},
                        new Filter() {Question="Yüzme dersini hangi amaçla almak istiyorsun(yarışma için, kendim için vs)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Piyano Dersi", Url="piyano-dersi", ImageUrl="piyano-dersi.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın(zoom/ev)"},
                        new Filter() {Question="Dersi alacak kişi(ler) kaç yaşında"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Tenis Dersi", Url="tenis-dersi", ImageUrl="tenis-dersi.jpg",
                    Filters= new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın"},
                        new Filter() {Question="Ders alacak kişi(ler) kaç yaşında"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="TYT AYT Matematik Özel Ders", Url="tyt-ayt-matematik-ozel-ders", ImageUrl="tyt-ayt-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın(zoom/ev)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçıncı sınıfa gidiyor"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Personal Trainer", Url="personal-trainer", ImageUrl="personal-trainer.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın(zoom/ev)"},
                        new Filter() {Question="Personel trainer cinsiyet tercihi"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Fitness yapma hedefin nedir"},
                        new Filter() {Question="İhtiyacının detayları neler"}
                    }},
                new SubCategory() {Name="Online Almanca Özel Ders", Url="online-almanca-ozel-ders", ImageUrl="online-almanca-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders alacak kişi okula gidiyor mu"},
                        new Filter() {Question="Hangi seviyede"},
                        new Filter() {Question="Amacı nedir(TOFL,YDS) vs"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Lise Matematik Özel Ders", Url="lise-matematik-ozel-ders", ImageUrl="lise-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacağı yer(zoom/ev)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçıncı sınıfa gidiyor"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Online Öğrenci Koçu", Url="online-ogrenci-kocu", ImageUrl="online-ogrenci-kocu.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Hangi konuda destek istiyorsun"},
                        new Filter() {Question="Hangi sıklıkta görüşmek istiyorsun"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="LGS Matematik Özel Ders", Url="lgs-matematik-ozel-ders", ImageUrl="lgs-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacağı yer(zoom/ev)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçıncı sınıfa gidiyor"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Pilates Dersi", Url="pilates-dersi", ImageUrl="pilates-dersi.jpg",
                    Filters= new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacğı yer(zoom/ev)"},
                        new Filter() {Question="Hangi tür pilates ile ilgileniyorsun"},
                        new Filter() {Question="Pilates ile ilgili hedefin ne"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="İlkokul Matemarik Özel Ders", Url="ilkokul-matematik-ozel-ders", ImageUrl="ilkokul-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Dersin yapılacağı yer(zoom/yer)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçıncı sınıfta"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Gitar Dersi", Url="gitar-dersi", ImageUrl="gitar-dersi.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın(zoom/ev)"},
                        new Filter() {Question="Hangi tür gitarda ders almak istiyorsun"},
                        new Filter() {Question="Dersi alacak kişi kaç yaşında"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi nasıl almak istiyorsun(birebir veya grup)"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Online Ortaokul Matematik Özel Ders", Url="online-ortaokul-matematik-ozel-ders", ImageUrl="online-ortaokul-matematik-ozel-ders.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Dersi alacak kişi kaçınxı sınıfa gidiyor"},
                        new Filter() {Question="Ne kadar süre"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},

                new SubCategory() {Name="Keman Dersi", Url="keman-dersi", ImageUrl="keman-dersi.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerde yapılsın(zoom/ev)"},
                        new Filter() {Question="Dersi alacak kişi kaç yaşında"},
                        new Filter() {Question="Keman var mı"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }},
                new SubCategory() {Name="Şan Dersi", Url="san-dersi", ImageUrl="san-dersi.jpg",
                    Filters = new List<Filter>()
                    {
                        new Filter() {Question="Ders nerede yapılsın(zoom/ev)"},
                        new Filter() {Question="Ne amaçla alıyorsun(profesyonel, hobi)"},
                        new Filter() {Question="Hangi sıklıkta ay/hafta"},
                        new Filter() {Question="Eğitmenin dikkat etmesi gereken detaylar"}
                    }
                }
                } },
            new Category() {Name="Sağlık", Url="saglik", ImageUrl="saglik.jpg", SubCategories=new List<SubCategory>(){
                new SubCategory() { Name = "Psikolog", Url = "psikolog", ImageUrl = "psikolog.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Nasıl Görüşmek İstersiniz?" }, new Filter() { Question= "Hangi konuda destek almak istiyorsunuz?" }, new Filter() { Question= "Yaşınız?" }, new Filter() { Question= "Daha önce destek aldınız mı?" }, new Filter() { Question= "detayları yazınız." }, } },
                new SubCategory() { Name = "Diyetisyen", Url = "diyetisyen", ImageUrl = "diyetisyen.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Nasıl Görüşmek İstersiniz?" },new Filter() { Question= "Hangi konuda destek istiyorsunuz?" },new Filter() { Question= "Kaç yaşındasınız?" },new Filter() { Question= "detayları yazınız." }, }},
                new SubCategory() { Name = "Personel Trainer", Url = "personel-trainer", ImageUrl = "personel-trainer.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Nasıl görüşmek istersiniz?" },new Filter() { Question= "Eğitmen tercihiniz?" },new Filter() { Question= "Hedefiniz nedir?" },new Filter() { Question= "Hangi sıklıkla?" },new Filter() { Question= "detayları yazınız." }, }},
                new SubCategory() { Name = "Masaj(Erkek İçin)", Url = "masaj-erkek-icin", ImageUrl = "masaj-erkek-icin.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Masaj tercihiniz?" }, new Filter() { Question = "Masör tercihiniz?" }, new Filter() { Question = "Kaç dakika istersiniz?" }, new Filter() { Question = "Nerede?" }, new Filter() { Question = "Hangi sıklıkla?" }, new Filter() { Question = "detayları yazınız." }, } },
                new SubCategory() { Name = "Fizyoterapist", Url = "fizyoterapist", ImageUrl = "fizyoterapist.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Hangi bölge için?" },new Filter() { Question= "Nerede?" },new Filter() { Question= "Ne kadar süre ihtiyacınız var?" },new Filter() { Question= "detayları yazınız." }, }},
                new SubCategory() { Name = "Dil ve Konuşma Terapisi", Url = "dil-ve-konusma-terapisi", ImageUrl = "dil-ve-konusma-terapisi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Nerede?" }, new Filter() { Question= "Hangi konuda destek istiyorsunuz?" },new Filter() { Question= "Kaç yaşında?" },new Filter() { Question= "detayları yazınız." }, }},
                new SubCategory() { Name = "Çocuk Bakımı ve Ev Yardımcısı", Url = "cocuk-bakimi-ve-ev-yardimcisi", ImageUrl = "cocuk-bakimi-ve-ev-yardimcisi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Ne ihtiyacınız var?" },new Filter() { Question= "Kaç gün istiyorsunuz?" },new Filter() { Question= "detayları yazınız." },}},
                new SubCategory() { Name = "Epilasyon", Url = "epilasyon", ImageUrl = "epilasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question= "hangi bölge?" }, new Filter() { Question= "kaç seans?" },new Filter() { Question= "detayları yazınız." }, }},
                new SubCategory() { Name = "Epilasyon", Url = "epilasyon", ImageUrl = "epilasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question= "hangi bölge?" },new Filter() { Question= "detayları yazınız." }, }},
                 new SubCategory() { Name = "Dövme", Url = "dovme", ImageUrl = "dovme.jpg", Filters = new List<Filter>(){ new Filter() { Question= "hangi bölge?" },new Filter() { Question= "detayları yazınız." }, }},
                 new SubCategory() { Name = "Yaşlı Bakımı", Url = "yasli-bakimi", ImageUrl = "yasli-bakimi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "nerede?" },new Filter() { Question= "kaç gün?" }, }},
            } },
            new Category() {Name="Organizasyon", Url="organizasyon", ImageUrl="organizasyon.jpg", SubCategories=new List<SubCategory>(){
                new SubCategory() {Name="Nişan Organizasyon ", Url="nisan-organizasyon", ImageUrl="nisan-organizasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question="Nasıl bir nişan organizasyonu istiyorsunuz?" }, new Filter() { Question="Davetli sayısı nedir?" }, new Filter() { Question="Hangi hizmetleri istersin?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Catering", Url="catering", ImageUrl="catering.jpg", Filters = new List<Filter>(){ new Filter() { Question="Ne için catering istiyorsunuz?" }, new Filter() { Question= "Kaç kişilik?" }, new Filter() { Question= "Hangi öğün(ler)?" }, new Filter() { Question = "Kaç çeşit yemek?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Doğum Günü Organizasyonu", Url="dogum-gunu-organizasyon", ImageUrl="dogum-gunu-organizasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Doğum günü sahibi kaç yaşına giriyor?" }, new Filter() { Question= "Nasıl bir organizasyon hizmeti istiyorsun?" }, new Filter() { Question= "Kaç davetli?" }, new Filter() { Question = "Hangi hizmetleri istersin?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Palyaço", Url="palyaco", ImageUrl="palyaco.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Palyaço hangi etkinlikleri yapsın?" }, new Filter() { Question= "Kaç çocukla ilgilenecek?" }, new Filter() { Question= "Kaç saat?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Doğum Günü Mekanları ", Url="dogum-gunu-mekanlari", ImageUrl="dogum-gunu-mekanlari.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Doğum günü sahibi kaç yaşına giriyor?" }, new Filter() { Question= "Kaç davetli?" }, new Filter() { Question= "Hangi hizmetlerin verilmesini istiyorsun?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Butik Pasta", Url="butik-pasta", ImageUrl="butik-pasta.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Kaç kişilik?" }, new Filter() { Question= "Hangisini istersin?" }, new Filter() { Question= "Hangi Etkinlik için?" }, new Filter() { Question = "Teslimat nasıl yapılsın?" }, new Filter() { Question = "Fotoğraf eklemek ister misin?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Söz Organizasyon", Url="soz-organizasyon", ImageUrl="soz-organizasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Mekan gerekiyor mu?" }, new Filter() { Question= "Kaç davetli olacak?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Evlilik Teklifi Organizasyon", Url="evlilik-teklifi-organizasyon", ImageUrl="evlilik-teklifi-organizasyon.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Nerede teklif yapmak istiyorsunuz?" }, new Filter() { Question= "Nasıl bir teklif?" }, new Filter() { Question= "Yemek Masası ister misin?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Davul Zurnacı Kiralama", Url="davul-zurnaci-kiralama", ImageUrl="davul-zurnaci-kiralama.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Hangi organizasyon için istiyorsun?" }, new Filter() { Question= "Kaç Saat?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="Bando Takımı", Url="bando-takimi", ImageUrl="bando-takimi.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Hangi organizasyon için istiyorsun?" }, new Filter() { Question= "Kaç Saat?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},
                new SubCategory() {Name="DJ", Url="dj", ImageUrl="dj.jpg", Filters = new List<Filter>(){ new Filter() { Question= "Hangisi için DJ arıyorsunuz?" }, new Filter() { Question= "Ses sitemi de gerekiyor mu?" }, new Filter() { Question = "Kaç davetli?" }, new Filter() { Question = "Ne kadar süre?" }, new Filter() { Question="Ayrıntılar" }, new Filter() { Question="Adres" }, new Filter() { Question="Tarih" }}},

                } },
            new Category() {Name="Diğer", Url="diger", ImageUrl="diger.jpg"},
        };
        //private static SubCategory[] SubCategories = new SubCategory[]
        //{
        //    SubCategory =new List<SubCategory>()
        //    {

                //new SubCategory() { Name = "Psikolog", Url = "psikolog", ImageUrl = "psikolog.jpg", CategoryId = "6" },
                //new SubCategory() { Name = "Diyetisyen", Url = "diyetisyen", ImageUrl = "diyetisyen.jpg", CategoryId = "6" },
                //new SubCategory() { Name = "Personel Trainer", Url = "personel-trainer", ImageUrl = "personel-trainer.jpg"},
                //new SubCategory() { Name = "Masaj(Erkek İçin)", Url = "masaj-erkek-icin", ImageUrl = "masaj-erkek-icin.jpg", CategoryId = "6" },
                //new SubCategory() { Name = "Fizyoterapist", Url = "fizyoterapist", ImageUrl = "fizyoterapist.jpg", CategoryId = "6" },
                //new SubCategory() { Name = "Dil ve Konuşma Terapisi", Url = "dil-ve-konusma-terapisi", ImageUrl = "dil-ve-konusma-terapisi.jpg", CategoryId = "6" },
                //new SubCategory() { Name = "Çocuk Bakımı ve Ev Yardımcısı", Url = "cocuk-bakimi-ve-ev-yardimcisi", ImageUrl = "cocuk-bakimi-ve-ev-yardimcisi.jpg"},
                //new SubCategory() { Name = "Epilasyon", Url = "epilasyon", ImageUrl = "epilasyon.jpg", CategoryId = "6" },

                //new SubCategory() { Name = "Nişan Organizasyon ", Url = "nisan-organizasyon", ImageUrl = "nisan-organizasyon.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Catering", Url = "catering", ImageUrl = "catering.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Doğum Günü Organizasyonu", Url = "dogum-günü-organizasyonu", ImageUrl = "dogum-günü-organizasyonu.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Palyaço", Url = "palyaco", ImageUrl = "palyaco.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Doğum Günü Mekanları ", Url = "dogum-gunu-mekanlari", ImageUrl = "dogum-gunu-mekanlari.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Butik Pasta", Url = "butik-pasta", ImageUrl = "butik-pasta.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Söz Organizasyon", Url = "soz-organizasyonu", ImageUrl = "soz-organizasyonu.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Evlilik Teklifi Organizasyon", Url = "evlilik-teklifi-organizasyonu", ImageUrl = "evlilik-teklifi-organizasyonu.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Davul Zurnacı Kiralama", Url = "davul-zurnaci-kiralama", ImageUrl = "davul-zurnaci-kiralama.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "Bando Takımı", Url = "bando-takimi", ImageUrl = "bando-takimi.jpg", CategoryId = "7" },
                //new SubCategory() { Name = "DJ", Url = "dj", ImageUrl = "dj.jpg", CategoryId = "7" },

                //new SubCategory() {Name="Diğer", Url="diger", ImageUrl="diger.jpg", CategoryId="8"},

        //    }

        //};
        public static void Seed()
        {
            ElmaContext context = new ElmaContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    foreach (var cat in Categories)
                    {
                        context.Add(cat);
                    }
                }
                
            }

            context.SaveChanges();
        }

    }
}
