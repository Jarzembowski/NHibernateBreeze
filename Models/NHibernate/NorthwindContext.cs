using Breeze.ContextProvider.NH;
using NHibernateTest.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateTest.Models.NHibernate
{
   public class NorthwindContext: NHContext
   {
      public NorthwindContext() : base(NHibernateSession.CreateSessionFactory()) { }

      public NorthwindContext Context
      {
         get { return this; }
      }
      public NhQueryableInclude<Employee> Employee
      {
         get { return GetQuery<Employee>(); }
      }

      public NhQueryableInclude<Product> Product
      {
         get { return GetQuery<Product>(); }
      }
      public NhQueryableInclude<Store> Store
      {
         get { return GetQuery<Store>(); }
      }
     
    
   }
}