using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsX.Mvc.Models
{
    public class PessoaFisicaPutRequestModel
    {
        /// <summary>
        /// Identificador da pessoa física
        /// </summary>
        public Guid Id { get; set; }
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
        [Display(Name = "Documento")]
        public string Cpf { get; set; }
    }
}
