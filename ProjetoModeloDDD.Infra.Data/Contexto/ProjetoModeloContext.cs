using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjetoModelo.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        //Construtor
        public ProjetoModeloContext() : base("ProjetoModeloDDD"){ }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<CentroCusto> CentrosCusto { get; set; }
        public DbSet<TipoMaoObra> TiposMaoObra { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        

        /// <summary>
        /// Overrride no metodo OnModelCreating para modificar paramentros de criação da entidade na base de dados
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remover pluralização no nome das tabelas e deletes em cascata
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Forçar todas as propriedades que contenham ID no nome serem PrimaryKey no BD
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "ID")
                .Configure(p => p.IsKey());

            //Forçar criação dos tipos de string para varchar() na base de dados : O padrão cria nVarchar que é maior 
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            modelBuilder.Configurations.Add(new ProjetoConfiguration());
            modelBuilder.Configurations.Add(new CentroCustoConfiguration());
            modelBuilder.Configurations.Add(new TipoMaoObraConfiguration());
            modelBuilder.Configurations.Add(new DisciplinaConfiguration());
            modelBuilder.Configurations.Add(new CommodityConfiguration());
        }

        /// <summary>
        /// Verifica a entidade no momento da alteração para preencher a data de cadastro
        /// </summary>
        /// <returns>base.SaveChanges()</returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}
