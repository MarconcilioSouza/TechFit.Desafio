using System;
using System.Collections.Generic;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Dominio.Interfaces.Services;

namespace TechFit.Desafio.Aplicacao.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> repositorio;

        public AppServiceBase(IServiceBase<TEntity> repositorio)
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
            repositorio.Deletar(id);
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
