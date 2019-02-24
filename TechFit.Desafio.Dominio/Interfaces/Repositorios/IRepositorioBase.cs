using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TechFit.Desafio.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity>  where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTotos();
        void Alterar(TEntity obj);
        void Deleta(int id);
        void Deletar(TEntity obj);
    }
}
