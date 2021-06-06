using System.ComponentModel.DataAnnotations;

namespace Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}