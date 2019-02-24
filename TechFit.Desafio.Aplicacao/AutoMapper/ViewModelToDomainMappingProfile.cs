using AutoMapper;
using TechFit.Desafio.Aplicacao.ViewModels;
using TechFit.Desafio.Dominio.Entidades;

namespace TechFit.Desafio.Aplicacao.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AlimentosViewModel, Alimento>();
        }
    }
}
