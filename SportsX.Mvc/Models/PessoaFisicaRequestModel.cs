using System.ComponentModel.DataAnnotations;

namespace SportsX.Mvc.Models
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
        [StringLength(11)]
        [Required]
        public string Cpf { get; set; }
    }
}
