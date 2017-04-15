using System.ComponentModel.DataAnnotations;

namespace Mau.PauloMau.Infra.CrossCutting.Security.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}