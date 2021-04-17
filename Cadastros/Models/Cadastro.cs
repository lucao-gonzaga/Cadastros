using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastros.Models
{
    public class Cadastro
    {
        [Key]
        public long? CadastroID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Display(Name = "Livro")]
        public string Livro { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [EmailAddress(ErrorMessage = "Email invalido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public string Telefone { get; set; }
        public string Validade { get; set; }
    }
}
