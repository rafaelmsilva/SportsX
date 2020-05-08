using SportsX.Domain.Entities.Enums;

namespace SportsX.Mvc.Models
{
    public class TelefoneRequestModel
    {
        public string Numero { get; set; }
        public TipoTelefoneEnum TipoTelefone { get; set; }
    }
}
