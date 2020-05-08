using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsX.Mvc.Models
{
    public class PessoaJuridicaRequestModel
    {
        [Display(Name ="Documento")]
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
    }
}
