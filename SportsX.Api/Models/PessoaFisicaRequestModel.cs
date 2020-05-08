using System.ComponentModel.DataAnnotations;

namespace SportsX.Api.Models
{
    /// <summary>
    /// Modelo para criação de uma Pessoa física
    /// </summary>
    public class PessoaFisicaRequestModel
    {
        /// <summary>
        /// Propriedade nome da pessoa
        /// </summary>
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// CPF da Pessoa
        /// </summary>
        [Required]
        public string Cpf { get; set; }
    }
}
