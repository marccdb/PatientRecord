using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FichaAtendimento.Shared.Model
{
    public class Ficha
    {
        [Key]
        public int idFicha { get; set; }

        [Required]
        public int idPaciente { get; set; }

        [Required]
        public string NomePaciente { get; set; }

        public string ResumoAtendimento { get; set; }

        [Required]
        public bool SessaoPaga { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataAtendimento
        {
            get { return DateTime.Today; }
            set { }
        }

        public string Observacoes { get; set; }

        [Required]
        public bool ReciboEntregue { get; set; }

    }
}
