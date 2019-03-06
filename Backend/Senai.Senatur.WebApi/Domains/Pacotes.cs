using System;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int PacoteId { get; set; }

        [Required(ErrorMessage = "Informe o nome do pacote")]
        public string NomePacote { get; set; }

        [Required(ErrorMessage = "Informe a descrição do pacote")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a data de ida")]
        [DataType(DataType.Date)]
        public DateTime DataIda { get; set; }

        [Required(ErrorMessage = "Informe a data de volta")]
        [DataType(DataType.Date)]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "Informe o preço do pacote")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe o status do pacote")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Informe o nome da cidade")]
        public string NomeCidade { get; set; }
    }
}
