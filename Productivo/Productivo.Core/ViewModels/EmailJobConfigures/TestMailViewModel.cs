using System.ComponentModel.DataAnnotations;

namespace Productivo.Core.ViewModels.EmailJobConfigures
{
    public class TestMailViewModel
    {
        [Required(ErrorMessage = "La direccion del destinatario es requerida")]
        [Display(Name = "Destinatario")]
        public string To { get; set; }

        [Required(ErrorMessage = "El asunto del correo es requerido")]
        [Display(Name = "Asunto")]
        public string subject { get; set; }

        [Display(Name = "Mensaje")]
        public string content { get; set; }

    }
}
