using TechFit.Desafio.Dominio.Entidades;

namespace TechFit.Desafio.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioAlimento : IRepositorioBase<Alimento>
    {
        Alimento ObterPorNome(string nome);
    }
}
