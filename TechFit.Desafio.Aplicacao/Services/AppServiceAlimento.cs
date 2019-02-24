using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using TechFit.Desafio.Aplicacao.AutoMapper;
using TechFit.Desafio.Aplicacao.Interfaces;
using TechFit.Desafio.Aplicacao.ViewModels;
using TechFit.Desafio.Dominio.Entidades;
using TechFit.Desafio.Dominio.Interfaces.Services;
using TechFit.Desafio.Dominio.Validadores;

namespace TechFit.Desafio.Aplicacao.Services
{
    public class AppServiceAlimento : IAppServiceAlimento
    {
        private readonly IServicoAlimento servicoAlimento;
        private readonly IMapper mapper;
        private readonly AlimentoValidator validator;

        public AppServiceAlimento(IServicoAlimento servicoAlimento)
        {
            this.servicoAlimento = servicoAlimento;
            mapper = AutoMapperConfig.Mapper;
            validator = new AlimentoValidator();
        }

        public IEnumerable<AlimentosViewModel> ObterTotos()
        {
            return mapper.Map<IEnumerable<AlimentosViewModel>>(servicoAlimento.ObterTotos());
        }

        public AlimentosViewModel ObterPorId(int id)
        {
            return mapper.Map<AlimentosViewModel>(servicoAlimento.ObterPorId(id));
        }

        public void Adicionar(AlimentosViewModel alimentoViewModel)
        {
            var alimento = mapper.Map<Alimento>(alimentoViewModel);
            validator.ValidateAndThrow(alimento);

            servicoAlimento.Adicionar(alimento);
        }

        public void Alterar(AlimentosViewModel alimentoViewModel)
        {
            var alimento = mapper.Map<Alimento>(alimentoViewModel);
            validator.ValidateAndThrow(alimento);

            servicoAlimento.Alterar(alimento);
        }

        public void Deletar(AlimentosViewModel alimentoViewModel)
        {
            var alimento = mapper.Map<Alimento>(alimentoViewModel);
            servicoAlimento.Deletar(alimento);
        }

        public void Deletar(int id)
        {
            servicoAlimento.Deletar(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public AlimentosViewModel ObterPorNome(string nome)
        {
            return mapper.Map<AlimentosViewModel>(servicoAlimento.ObterPorNome(nome));
        }
    }
}
