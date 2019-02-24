using System.Collections.Generic;
using TechFit.Desafio.Dominio.Interfaces.Repositorios;
using TechFit.Desafio.Dominio.Interfaces.Services;

namespace TechFit.Desafio.Dominio.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> repositorio;

        public ServiceBase(IRepositorioBase<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Adicionar(TEntity obj)
        {
            repositorio.Adicionar(obj);
        }

        public IEnumerable<TEntity> ObterTotos()
        {
            return repositorio.ObterTotos();
        }

        public TEntity ObterPorId(int id)
        {
            return repositorio.ObterPorId(id);
        }

        public void Deletar(int id)
        {
            repositorio.Deleta(id);    
        }

        public void Deletar(TEntity obj)
        {
            repositorio.Deletar(obj);
        }

        public void Alterar(TEntity obj)
        { 
            repositorio.Alterar(obj);
        }
    }
}
