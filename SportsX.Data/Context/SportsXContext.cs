using Microsoft.EntityFrameworkCore;
using SportsX.Domain.Entities;

namespace SportsX.Data.Context
{
    public class SportsXContext : DbContext
    {

        public SportsXContext(DbContextOptions<SportsXContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureCliente(modelBuilder);
            ConfigureEndereco(modelBuilder);
            ConfigurePessoaFisica(modelBuilder);
            ConfigurePessoaJuridica(modelBuilder);
            ConfigureTelefone(modelBuilder);
        }


        private void ConfigureCliente(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Cliente>(cli =>
            {
                cli.HasKey(c => c.Id);
                cli.Property(c => c.Nome).IsRequired().HasMaxLength(100);
                cli.Property(c => c.Email).IsRequired().HasMaxLength(100);
                cli.Property(c => c.Classificacao).IsRequired();
                cli.HasOne(c => c.Endereco);
                cli.HasOne(c => c.PessoaFisica);
                cli.HasOne(c => c.PessoaJuridica);
                cli.HasMany(c => c.Telefones);

            });
        }

        private void ConfigureEndereco(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Endereco>(end =>
            {
                end.HasKey(e => e.Id);
                end.Property(e => e.Cidade).HasMaxLength(100);
                end.Property(e => e.Complemento).HasMaxLength(50);
                end.Property(e => e.Bairro).HasMaxLength(100);
                end.Property(e => e.Cep).HasMaxLength(10);
                end.Property(e => e.Rua).HasMaxLength(100);
            });
        }

        private void ConfigurePessoaFisica(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<PessoaFisica>(pf =>
            {
                pf.HasKey(p => p.Id);
                pf.Property(p => p.Nome).HasMaxLength(100);
            });
        }

        private void ConfigurePessoaJuridica(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<PessoaJuridica>(pj =>
            {
                pj.HasKey(p => p.Id);
                pj.Property(p => p.RazaoSocial).HasMaxLength(100);
            });
        }

        private void ConfigureTelefone(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Telefone>(tel =>
            {
                tel.HasKey(t => t.Id);
                tel.Property(t => t.Numero).HasMaxLength(20);

            });
        }
    }
}
