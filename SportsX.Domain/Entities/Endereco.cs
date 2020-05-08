using System;

namespace SportsX.Domain.Entities
{
    public class Endereco : Entity
    {
        public string Cep { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public int Numero { get; private set; }
        public string Complemento { get; private set; }

        public Endereco()
        {
      
        }

        public Endereco(string cep, string rua, string bairro, string cidade, int numero, string complemento)
        {
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Numero = numero;
            Complemento = complemento;

        }

        public Endereco(Guid id,string cep, string rua, string bairro, string cidade, int numero, string complemento):base(id)
        {
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Numero = numero;
            Complemento = complemento;

        }
    }
}
