using System.ComponentModel.DataAnnotations;

namespace SportsX.Api.Models
{
    /// <summary>
    /// Endereço do cliente
    /// </summary>
    public class EnderecoRequestModel
    {
        /// <summary>
        /// Cep do cliente
        /// </summary>
        [StringLength(10)]
        public string Cep { get; set; }

        /// <summary>
        /// Rua em que o cliente reside
        /// </summary>
        [StringLength(100)]
        public string Rua { get; set; }

        /// <summary>
        /// Bairro em que o cliente reside
        /// </summary>
        [StringLength(100)]
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade em que o cliente reside 
        /// </summary>
        [StringLength(100)]
        public string Cidade { get; set; }

        /// <summary>
        /// Numero da residencia do cliente
        /// </summary>
        public int Numero { get; set; }


        /// <summary>
        /// Complemento (Ex. Ap.101) 
        /// </summary>
        [StringLength(50)]
        public string Complemento { get; set; }
    }
}
