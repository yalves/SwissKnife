using System.ComponentModel.DataAnnotations;

namespace Mau.PauloMau.Infra.CrossCutting.Security.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}