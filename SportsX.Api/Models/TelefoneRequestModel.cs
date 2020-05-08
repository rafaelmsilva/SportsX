using SportsX.Domain.Entities.Enums;

namespace SportsX.Api.Models
{
    public class TelefoneRequestModel
    {
        public string Numero { get; set; }
        public TipoTelefoneEnum TipoTelefone { get; set; }
    }
}
