using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichaAtendimento.Shared.Model
{
    public class Paciente
    {
        [Key]
        public int idPaciente { get; set; }

        [Required]
        public string NomePaciente { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNascimento
        {
            get { return DateTime.Today; }
            set { }
        }

        public string Endereco { get; set; }

        public string Profissao { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }
    }
}
