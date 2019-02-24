using TechFit.Desafio.Dominio.Entidades;
using TechFit.Desafio.Dominio.Interfaces.Repositorios;
using TechFit.Desafio.Dominio.Interfaces.Services;

namespace TechFit.Desafio.Dominio.Services
{
   public class ServiceAlimento : ServiceBase<Alimento>, IServicoAlimento
    {
        private readonly IRepositorioAlimento _repositorio;
        public ServiceAlimento(IRepositorioAlimento repositorio)
            : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public Alimento ObterPorNome(string nome)
        {
           return _repositorio.ObterPorNome(nome);
        }
    }
}
