using ElmaProjesi.BusinessLayer.Abstract;
using ElmaProjesi.BusinessLayer.Concrete;
using ElmaProjesi.DataAccessLayer.Abstract;
using ElmaProjesi.DataAccessLayer.Concrete;
using ElmaProjesi.WebUI.EmailServices;
using ElmaProjesi.WebUI.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ElmaProjesi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationContext>(option => option.UseSqlServer("Server=haftaicisabahci;Database=ElmaProject;Integrated Security=true"));
            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = true;   // password^de mutlaka sayýsal bir deðer olmalý.
                options.Password.RequireLowercase = true; //password'de mutlaka küçük harf olmalý.
                options.Password.RequireUppercase = true;   // password'de mutlaka büyük harf olmalý.
                options.Password.RequiredLength = 6;    // password en az 6 karakter olmalý.
                options.Password.RequireNonAlphanumeric = true; // rakam ve harf dýþýnda farklý bir karakterin de password içinde olmasý gerekiyor. Örn: nokta gibi, @ gibi, %,-,_ gibi karakterler...

                // lockout : Kullanýcý hesabýnýn klilitlenip kilitlenmemsi ile ilgili.
                options.Lockout.MaxFailedAccessAttempts = 5;    // yanlýþ parolayý 5 kere girilebilir. Sonra hesap kilitlenir.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Hesap kilitlendikten 5 dakika sonra kullanýcý giriþ yapmayý deneyebilir.

                //User
                options.User.RequireUniqueEmail = true;   // her kullanýcý tek bir email adresi ile sisteme girebilir. Yani uniq email kullanýlýr. Ayný email ile 2 hesap açýlamaz.
                options.SignIn.RequireConfirmedEmail = false; // true olursa kullanýcý üye olur fakat email'ini mutlaka onaylamasý gerekir. false olursa üye olup hemen sisteme girebilir.
                options.SignIn.RequireConfirmedPhoneNumber = false; // True olursa telefon bilgisi için onay ister

            });

            // 4-1: Cookie ayarlarý: Cookie (Çerez): Kullanýcýnýn tarayýcýsýna býrakýlan bir bilgi diyebiliriz kýsaca. 
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";   // sisteme login olmadýysak bizi login sayfasýna yönlendiriyor. login olduysak da bize eþsiz bir sayý üretiyor.. Bu sayýyý server tarafýnda session'da tutuluyor, Cilent tarafýnda ise cookie içinde tutluyor.. Kullanýcý bir iþlem yaptýktan sonra belirli bir süre sonunda bu bilgi siliniyor. Belirtilen özelliklere göre, bu veri belirtilen süre içinde tekrar bir iþlem yapýlýrsa, tekrar login olmamýza gerek kalmýyor. Fakat süre bittikten sonra tekrar login olmamýz gerekiyor.
                options.LogoutPath = "/Account/Logout";  //Çýkýþ iþlemi yaptýðýmda cookie tarayýcýdan silinecek Ve tekrar bir iþlem yapmak istediðimde login sayfasýna yönlendirileceðim.
                options.AccessDeniedPath = "/Account/Accessdenied"; // Yetkisiz iþlem yapýldýðýnda çalýþacak olan Action.. Örneðin sýradan bir kullanýcý Admin ile ilgili bir sayfaya ulaþmaya çalýþtýðýnda çalýþacak.

                options.SlidingExpiration = true; // Örneðin sisteme girdim iþlem yaptým ve bekledim. varsayýlan deðer 20dakika. 20dakikadan sonra cookie'de bu bilgi silenecek. Eðer 20 dakika içinde tekrardan bir iþlem yaparsam bu süre tekrardan 20 dakika olarak ayarlanacak. False olursa login olduktan sonra 20 dakika sonunda cookie silinecektir.
                options.ExpireTimeSpan = TimeSpan.FromMinutes(300); // default süresi 20dakika..

                options.Cookie = new CookieBuilder
                { HttpOnly = true, Name = ".Elma.Security.Cookie" };
                // HttpOnly = true sadece http ile istek geldiðinde ulaþýlabilir olsun diyoruz.
                // Name propertry'si ile de Cookie'ye özel bir isim verebiliyoruz.
            });

            // IoC Container

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
            builder.Services.AddScoped<ISubCategoryService, SubCategoryManager>();

            builder.Services.AddScoped<IFilterRepository, FilterRepository>();
            builder.Services.AddScoped<IFilterService, FilterManager>();

            //Email Settings
            builder.Services.AddScoped<IEmailSender, EmailSender>(x =>
            new EmailSender("smtp.office365.com", 587, true, "deneme1246435@hotmail.com", "d1246435*")
            );
          
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                MyInitialData.Seed();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllerRoute(
                name: "admin",
                pattern: "admin/addcategory",
                defaults: new { controller = "Admin", action = "CategoryCreate" }
                );

            app.MapControllerRoute(
                name: "admin",
                pattern: "admin/categories",
                defaults: new { controller = "Admin", action = "CategoryList" }
                );

            app.MapControllerRoute(
                name: "categories",
                pattern: "/categories",
                defaults: new { controller = "Category", action = "Index" }
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}