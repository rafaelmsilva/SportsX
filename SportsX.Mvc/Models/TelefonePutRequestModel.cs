using SportsX.Domain.Entities.Enums;
using System;

namespace SportsX.Mvc.Models
{
    public class TelefonePutRequestModel
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefoneEnum TipoTelefone { get; set; }
    }
}
