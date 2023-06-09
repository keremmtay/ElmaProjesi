using ElmaProjesi.DataAccessLayer.Concrete;
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
            builder.Services.AddDbContext<ApplicationContext>(option => option.UseSqlServer("Server=203-Semih\\na;Database=ElmaProject;Integrated Security=true"));
            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            //4- Veritabaný tablolarýný oluþturduktan sonra Identity ile ilgili bir takým özelliklerin konfigürasyonunu aþaðýdaki gibi yapabiliriz.
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
                pattern: "admin",
                defaults: new { controller = "Admin", action = "Admin" }
                );

            app.MapControllerRoute(
                name: "admin",
                pattern: "admin",
                defaults: new { controller = "Admin", action = "AdminCategoryList" }
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