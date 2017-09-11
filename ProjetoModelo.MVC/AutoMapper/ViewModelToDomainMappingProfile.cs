using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoModelo.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();
            CreateMap<ProjetoViewModel, Projeto>().ReverseMap();
            CreateMap<CentroCustoViewModel, CentroCusto>().ReverseMap();
            CreateMap<TipoMaoObraViewModel, TipoMaoObra>().ReverseMap();
            CreateMap<CommodityViewModel, Commodity>().ReverseMap();
            CreateMap<DisciplinaViewModel, Disciplina>().ReverseMap();
        }

       
    }
}