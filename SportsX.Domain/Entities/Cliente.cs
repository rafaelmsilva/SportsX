using SportsX.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace SportsX.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public PessoaFisica PessoaFisica { get; private set; }
        public PessoaJuridica PessoaJuridica { get; private set; }
        public ClassificacaoEnum Classificacao { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public List<Telefone> Telefones { get; private set; }

        public Cliente()
        {
        }

        public Cliente(string nome, PessoaFisica pessoaFisica, ClassificacaoEnum classificacao, string email,
            Endereco endereco, List<Telefone> telefones)
        {
            Nome = nome;
            PessoaFisica = pessoaFisica;
            Classificacao = classificacao;
            Email = email;
            Endereco = endereco;
            Telefones = telefones;

        }

        public Cliente(Guid id,string nome, PessoaFisica pessoaFisica, ClassificacaoEnum classificacao, string email,
            Endereco endereco, List<Telefone> telefones) :base(id)
        {
            
            Nome = nome;
            PessoaFisica = pessoaFisica;
            Classificacao = classificacao;
            Email = email;
            Endereco = endereco;
            Telefones = telefones;

        }

        public Cliente(string nome, PessoaJuridica pessoaJuridica, ClassificacaoEnum classificacao, string email,
            Endereco endereco, List<Telefone> telefones)
        {
            Nome = nome;
            PessoaJuridica = pessoaJuridica;
            Classificacao = classificacao;
            Email = email;
            Endereco = endereco;
            Telefones = telefones;
        }

        public Cliente(Guid id, string nome, PessoaJuridica pessoaJuridica, ClassificacaoEnum classificacao, string email,
            Endereco endereco, List<Telefone> telefones):base(id)
        {
            Nome = nome;
            PessoaJuridica = pessoaJuridica;
            Classificacao = classificacao;
            Email = email;
            Endereco = endereco;
            Telefones = telefones;
        }
    }
}
