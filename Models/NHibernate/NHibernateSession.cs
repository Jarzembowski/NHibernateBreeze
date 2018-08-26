using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernateTest.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateTest.Models.NHibernate
{
   public static class NHibernateSession
   {
      public static ISession CreateSessionFactory()
      {
         ISessionFactory sessionFactory = Fluently.Configure()
             .Database(
                  MsSqlConfiguration.MsSql2012
                  .ConnectionString(" Data Source=LAPTOP-FBA8Q1IL;Initial Catalog=Stores;Integrated Security=True")
               )
             .Mappings(m =>
                m.FluentMappings.AddFromAssemblyOf<Product>())
             .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
             .BuildSessionFactory();

         return sessionFactory.OpenSession();
      }

   }
}