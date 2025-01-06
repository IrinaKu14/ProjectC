using System.ComponentModel.DataAnnotations;

namespace Applications.Web.Shared.Models
{
    public class LoginRequest
    {
        [StringLength(10,MinimumLength = 5 )]
        public string Login { get; set; }
        public string Password { get; set; }
    }

   
}
 
