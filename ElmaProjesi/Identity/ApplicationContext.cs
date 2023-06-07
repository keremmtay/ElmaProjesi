using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElmaProjesi.WebUI.Identity
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        // 2- Context sınıfını Identity'nin özelleştirilmiş IdentityDbContext sınıfından türetiyoruz.
        //Constructor tanımlayıp dışarıdan bazı özellikler ekleyeceğiz.

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

    }
}
