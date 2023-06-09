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
            //4- Veritaban� tablolar�n� olu�turduktan sonra Identity ile ilgili bir tak�m �zelliklerin konfig�rasyonunu a�a��daki gibi yapabiliriz.
            builder.Services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = true;   // password^de mutlaka say�sal bir de�er olmal�.
                options.Password.RequireLowercase = true; //password'de mutlaka k���k harf olmal�.
                options.Password.RequireUppercase = true;   // password'de mutlaka b�y�k harf olmal�.
                options.Password.RequiredLength = 6;    // password en az 6 karakter olmal�.
                options.Password.RequireNonAlphanumeric = true; // rakam ve harf d���nda farkl� bir karakterin de password i�inde olmas� gerekiyor. �rn: nokta gibi, @ gibi, %,-,_ gibi karakterler...

                // lockout : Kullan�c� hesab�n�n klilitlenip kilitlenmemsi ile ilgili.
                options.Lockout.MaxFailedAccessAttempts = 5;    // yanl�� parolay� 5 kere girilebilir. Sonra hesap kilitlenir.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Hesap kilitlendikten 5 dakika sonra kullan�c� giri� yapmay� deneyebilir.

                //User
                options.User.RequireUniqueEmail = true;   // her kullan�c� tek bir email adresi ile sisteme girebilir. Yani uniq email kullan�l�r. Ayn� email ile 2 hesap a��lamaz.
                options.SignIn.RequireConfirmedEmail = false; // true olursa kullan�c� �ye olur fakat email'ini mutlaka onaylamas� gerekir. false olursa �ye olup hemen sisteme girebilir.
                options.SignIn.RequireConfirmedPhoneNumber = false; // True olursa telefon bilgisi i�in onay ister

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
                defaults: new {controller = "Category", action = "Index"}
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}