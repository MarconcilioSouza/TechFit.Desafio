using AutoMapper;
using TechFit.Desafio.Aplicacao.ViewModels;
using TechFit.Desafio.Dominio.Entidades;

namespace TechFit.Desafio.Aplicacao.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
           CreateMap<Alimento, AlimentosViewModel>();
        }
    }
}
