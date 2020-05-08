namespace SportsX.Domain.Entities
{
    public class PessoaJuridica : Entity
    {
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string cnpj, string razaoSocial)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }
    }
}
