using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace EasyTravelWeb.Models
{
    /// <summary>
    ///    IdentityUser
    /// </summary>

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser<int, CustomUserLogin, CustomUserRole,
        CustomUserClaim>
    {
        /// <summary>
        ///    
        /// </summary>
	    public string FirstName { get; set; }

        /// <summary>
        ///    
        /// </summary>
	    public string LastName { get; set; }

        /// <summary>
        ///    
        /// </summary>
		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
		}
    }

    /// <summary>
    ///    
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, CustomRole,
        int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        /// <summary>
        ///    
        /// </summary>
        public ApplicationDbContext()
            : base("EasyTravelConnectionString")
        {
        }

        /// <summary>
        ///    
        /// </summary>
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    /// <summary>
    ///    
    /// </summary>
    public class CustomUserRole : IdentityUserRole<int> { }
    /// <summary>
    ///    
    /// </summary>
    public class CustomUserClaim : IdentityUserClaim<int> { }
    /// <summary>
    ///    
    /// </summary>
    public class CustomUserLogin : IdentityUserLogin<int> { }

    /// <summary>
    ///    
    /// </summary>
    public class CustomRole : IdentityRole<int, CustomUserRole>
    {
        /// <summary>
        ///    
        /// </summary>
        public CustomRole() { }
        /// <summary>
        ///    
        /// </summary>
        public CustomRole(string name) { Name = name; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class CustomUserStore : UserStore<ApplicationUser, CustomRole, int,
        CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        /// <summary>
        ///    
        /// </summary>
        public CustomUserStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }

    /// <summary>
    ///    
    /// </summary>
    public class CustomRoleStore : RoleStore<CustomRole, int, CustomUserRole>
    {
        /// <summary>
        ///    
        /// </summary>
        public CustomRoleStore(ApplicationDbContext context)
            : base(context)
        {
        }
    }    
}