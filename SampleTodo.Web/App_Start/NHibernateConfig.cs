[assembly: WebActivator.PreApplicationStartMethod(typeof(SampleTodo.Web.App_Start.NHibernateConfig), "Start")]

namespace SampleTodo.Web.App_Start
{
    using System.Data;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate.Cfg;
    using NHibernate.Context;
    using NHibernate.Dialect;
    using NHibernate.Driver;
    using NHibernate.Tool.hbm2ddl;

    using SampleTodo.Mapping;
    using SampleTodo.Repository;

    /// <summary>
    /// NHibernate Config
    /// </summary>
    public static class NHibernateConfig
    {
        /// <summary>
        /// The connection string name
        /// </summary>
        private const string ConnectionStringName = "TodosDb";

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public static void Start()
        {
            var configuration = new Configuration();
            configuration.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.IsolationLevel = IsolationLevel.ReadCommitted;
                db.SchemaAction = SchemaAutoAction.Validate;
                db.ConnectionStringName = ConnectionStringName;
            });

            configuration.CurrentSessionContext<WebSessionContext>();
            var factory = Fluently.Configure(configuration)
                .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(TodoMap).Assembly))
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(false, true, false))
                .BuildSessionFactory();
            
            SessionSource.SetFactory(factory);

            
        }
    }
}