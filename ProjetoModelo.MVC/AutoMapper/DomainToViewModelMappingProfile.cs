using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Projeto, ProjetoViewModel>().ReverseMap();
            CreateMap<CentroCusto, CentroCustoViewModel>().ReverseMap();
            CreateMap<TipoMaoObra, TipoMaoObraViewModel>().ReverseMap();
            CreateMap<Commodity, CommodityViewModel>().ReverseMap();
            CreateMap<Disciplina, DisciplinaViewModel>().ReverseMap();
        }

    }
}