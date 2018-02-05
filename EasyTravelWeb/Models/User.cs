namespace EasyTravelWeb.Models
{
    /// <summary>
    ///    User Model
    /// </summary>

    public class User
    {
        /// <summary>
        ///    
        /// </summary>
        public User()
        {
        }

        /// <summary>
        ///    
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Email { get; set; }

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
        public string Password { get; set; }
    }
}
