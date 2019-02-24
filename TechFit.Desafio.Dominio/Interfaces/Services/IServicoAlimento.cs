using TechFit.Desafio.Dominio.Entidades;

namespace TechFit.Desafio.Dominio.Interfaces.Services
{
    public interface IServicoAlimento : IServiceBase<Alimento>
    {
        Alimento ObterPorNome(string nome);
    }
}
