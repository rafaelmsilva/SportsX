using SportsX.Domain.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsX.Api.Models
{
    /// <summary>
    /// Modelo para inclusão de novo cliente
    /// </summary>
    public class ClienteRequestModel
    {
        /// <summary>
        /// Nome do cliente
        /// </summary>
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        /// <summary>
        /// Dados de pessoa física
        /// </summary>
        public PessoaFisicaRequestModel PessoaFisica { get; set; }

        /// <summary>
        /// Classificação do cliente
        /// </summary>
        public ClassificacaoEnum Classificacao { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get;  set; }

        /// <summary>
        /// Endereço do cliente
        /// </summary>
        public EnderecoRequestModel Endereco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TelefoneRequestModel> Telefones { get; set; }
    }
}
