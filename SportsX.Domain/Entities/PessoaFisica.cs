using System;

namespace SportsX.Domain.Entities
{
    public class PessoaFisica : Entity
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public PessoaFisica()
        {

        }
        public PessoaFisica(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public PessoaFisica(Guid id, string nome, string cpf) : base(id)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}

