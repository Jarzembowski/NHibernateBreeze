using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NHibernateTest.Models.NHibernate;
using NHibernateTest.Models.Entities;
using Breeze.ContextProvider.NH;

namespace NHibernateTest.Controllers
{
   [BreezeNHController]
   public class ProductController : ApiController
   {
      private NorthwindContext northwind;
      protected override void Initialize(System.Web.Http.Controllers.HttpControllerContext controllerContext)
      {
         base.Initialize(controllerContext);
         northwind = new NorthwindContext();
      }

      [HttpGet]
      public IQueryable<Product> Products()
      {
         var products = northwind.Product;
         return products;
      }

      [HttpGet]
      public String Metadata()
      {
         return northwind.Metadata();
      }


   }
}
