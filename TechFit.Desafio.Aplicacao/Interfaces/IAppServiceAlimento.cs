using TechFit.Desafio.Aplicacao.ViewModels;

namespace TechFit.Desafio.Aplicacao.Interfaces
{
    public interface IAppServiceAlimento : IAppServiceBase<AlimentosViewModel>
    {
        AlimentosViewModel ObterPorNome(string nome);
    }
}
