using SportsX.Domain.Entities.Enums;
using System;

namespace SportsX.Domain.Entities
{
    public class Telefone : Entity
    {
        public string Numero { get; private set; }
        public TipoTelefoneEnum? TipoTelefone { get; private set; }

        public Telefone()
        {
        }

        public Telefone(string numero, TipoTelefoneEnum? tipoTelefone)
        {
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }

        public Telefone(Guid id,string numero, TipoTelefoneEnum? tipoTelefone):base(id)
        {
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }

    }
}
