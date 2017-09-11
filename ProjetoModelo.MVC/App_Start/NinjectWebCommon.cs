[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoModelo.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoModelo.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoModelo.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Modules;
    using Ninject.Web.Common;

    //using ProjetoModeloDDD.Application;
    //using ProjetoModeloDDD.Application.Interface;
    //using ProjetoModelo.Domain.Interfaces.Repositories;
    //using ProjetoModelo.Domain.Interfaces.Services;
    //using ProjetoModelo.Domain.Services;

    using GerenciadorDependencia;

    //Criar um modulo separado para fazer o IoC (DI) e retirar essa referencia do projeto de aplicacao
    //using ProjetoModeloDDD.Infra.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            #region "Criado no projeto de Gerenciamento de dependencia na classe exclusiva para o Entity Framework para fazer o IoC"
            //TODO: Criar um modulo para isolar o ninject e nao precisar das referencias da camada de Infra.Data, por exemplo.
            //kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            //kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            //kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            //
            //kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            //kernel.Bind<IClienteService>().To<ClienteService>();
            //kernel.Bind<IProdutoService>().To<ProdutoService>();
            //
            //kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            //kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            //kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            #endregion "Criado no projeto de Gerenciamento de dependencia na classe exclusiva para o Entity Framework para fazer o IoC"

            var modules = new INinjectModule[] 
            {
                new ConfigDependenciaEF()
                //, outra dependencia qualquer no projeto que Gerencia as dependencias
            };
            
            kernel.Load(modules);
        }        
    }
}
