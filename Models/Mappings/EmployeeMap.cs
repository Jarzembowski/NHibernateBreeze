using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using NHibernateTest.Models.Mappings;
using NHibernateTest.Models.Entities;
using FluentNHibernate.Mapping;

namespace NHibernateTest.Models.Mappings
{
   public class EmployeeMap : ClassMap<Employee>

   {
      public EmployeeMap()
      {
         Id(x => x.Id);
         Map(x => x.FirstName);
         Map(x => x.LastName);
         Map(x => x.Salary);
         References(x => x.Store);
      }
   }
}