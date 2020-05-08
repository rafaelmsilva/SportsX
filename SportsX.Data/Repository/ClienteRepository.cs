using Microsoft.EntityFrameworkCore;
using SportsX.Data.Context;
using SportsX.Domain.Entities;
using SportsX.Domain.Interfaces;
using System;
using System.Linq;

namespace SportsX.Data.Repository
{
    public class ClienteRepository : IRepositoryBase<Cliente>
    {

        protected readonly SportsXContext Db;
        protected readonly DbSet<Cliente> DbSet;

        public ClienteRepository(SportsXContext context)
        {
            Db = context;
            DbSet = Db.Set<Cliente>();
        }

        public void Add(Cliente obj)
        {
            DbSet.Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public IQueryable<Cliente> GetAll()
        {
            return DbSet.Include(c => c.Endereco)
                .Include(c => c.PessoaFisica)
                .Include(c => c.PessoaJuridica)
                .Include(c => c.Telefones);
        }

        public Cliente GetById(Guid id)
        {
            return DbSet.Include(c => c.Endereco)
                .Include(c => c.PessoaFisica)
                .Include(c => c.PessoaJuridica)
                .Include(c => c.Telefones).ToList().Find(c=> c.Id == id);
        }

        public void Remove(Guid id)
        {
            var obj = DbSet.Find(id);
            DbSet.Remove(obj);
            Db.SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Update(Cliente obj)
        {
            var cliente = GetById(obj.Id);

            Db.SaveChanges();
        }
    }
}
