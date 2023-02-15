using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [DisplayName("Nome completo")]
        [Required(ErrorMessage = " O campo {0} é requirido ")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = " O campo {0} é requirido ")]
        [EmailAddress(ErrorMessage = "E-mail formato errado")]
        public string Email { get; set; }

        [Required(ErrorMessage = " O campo {0} é requirido ")]
        public string CPF { get; set; }
        public string Descricao { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Ativo { get; set; }
    }
}