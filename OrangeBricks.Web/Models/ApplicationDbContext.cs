using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;

namespace OrangeBricks.Web.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IOrangeBricksContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations.Configuration>("DefaultConnection"));
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Property> Properties { get; set; }
        public IDbSet<Offer> Offers { get; set; }
        public IDbSet<Viewing> Viewings { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public System.Data.Entity.DbSet<OrangeBricks.Web.Controllers.Property.ViewModels.BookViewingViewModel> BookViewingViewModels { get; set; }
    }

    public interface IOrangeBricksContext
    {
        IDbSet<Property> Properties { get; set; }
        IDbSet<Offer> Offers { get; set; }

        IDbSet<Viewing> Viewings { get; set; }
        

        void SaveChanges();
    }
}