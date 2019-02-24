using System.Collections.Generic;

namespace TechFit.Desafio.Aplicacao.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTotos();
        void Alterar(TEntity obj);
        void Deletar(int id);
        void Deletar(TEntity obj);
    }
}
