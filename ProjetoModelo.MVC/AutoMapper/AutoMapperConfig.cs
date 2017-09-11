using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
namespace ProjetoModelo.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }

        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
            });
            return config;
        }

    }
}