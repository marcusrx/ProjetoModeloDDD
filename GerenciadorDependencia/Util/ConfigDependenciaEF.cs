using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModelo.Domain.Interfaces.Repositories;
using ProjetoModelo.Domain.Interfaces.Services;
using ProjetoModelo.Domain.Services;

using ProjetoModeloDDD.Infra.Data.Repositories;

namespace GerenciadorDependencia
{
    public class ConfigDependenciaEF : NinjectModule
    {
        public override void Load()
        {
            //Application
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IClienteAppService>().To<ClienteAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IProjetoAppService>().To<ProjetoAppService>();
            Bind<ICentroCustoAppService>().To<CentroCustoAppService>();
            Bind<ITipoMaoObraAppService>().To<TipoMaoObraAppService>();
            Bind<IDisciplinaAppService>().To<DisciplinaAppService>();
            Bind<ICommodityAppService>().To<CommodityAppService>();

            //Domain
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IClienteService>().To<ClienteService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IProjetoService>().To<ProjetoService>();
            Bind<ICentroCustoService>().To<CentroCustoService>();
            Bind<ITipoMaoObraService>().To<TipoMaoObraService>();
            Bind<IDisciplinaService>().To<DisciplinaService>();
            Bind<ICommodityService>().To<CommodityService>();

            //Repository
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IProjetoRepository>().To<ProjetoRepository>();
            Bind<ICentroCustoRepository>().To<CentroCustoRepository>();
            Bind<ITipoMaoObraRepository>().To<TipoMaoObraRepository>();
            Bind<IDisciplinaRepository>().To<DisciplinaRepository>();
            Bind<ICommodityRepository>().To<CommodityRepository>();
        }
    }
}
