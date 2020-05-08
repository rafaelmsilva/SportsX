using SportsX.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsX.Mvc.Models
{
    public class ClientePutRequestModel
    {
        /// <summary>
        /// Identificador do cliente
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [StringLength(100, MinimumLength = 3)]
        public string Nome { get; set; }

        /// <summary>
        /// Dados de pessoa física
        /// </summary>
        public PessoaFisicaPutRequestModel PessoaFisica { get; set; }

        /// <summary>
        /// Classificação do cliente
        /// </summary>
        public ClassificacaoEnum Classificacao { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Endereço do cliente
        /// </summary>
        public EnderecoPutRequestModel Endereco { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TelefonePutRequestModel> Telefones { get; set; }
    }
}
