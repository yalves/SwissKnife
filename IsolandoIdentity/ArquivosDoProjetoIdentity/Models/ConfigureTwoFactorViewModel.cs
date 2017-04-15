using System.Collections.Generic;

namespace Mau.PauloMau.Infra.CrossCutting.Security.Models
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}