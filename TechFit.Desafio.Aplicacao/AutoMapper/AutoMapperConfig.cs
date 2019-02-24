﻿using AutoMapper;

namespace TechFit.Desafio.Aplicacao.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void RegisterMappings()
        {
            var mapper = new MapperConfiguration((m) =>
            {
                m.AddProfile<DomainToViewModelMappingProfile>();
                m.AddProfile<ViewModelToDomainMappingProfile>();
            });

            Mapper = mapper.CreateMapper();
        }
    }
}
