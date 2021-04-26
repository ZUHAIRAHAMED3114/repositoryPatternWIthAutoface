using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using System.Web.Http;
using System.Data.Entity;
using System.Web.Http.Dispatcher;
using depenDencyInjectionWIthAutoFac.customHttpControllerActivator;
using System.Web.Http.Controllers;
using depenDencyInjectionWIthAutoFac.Controllers;
using depenDencyInjectionWIthAutoFac.Models;
namespace depenDencyInjectionWIthAutoFac
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var builder = new ContainerBuilder();
            builder.RegisterType<TestController>()
                   .As<IHttpController>();

            builder.RegisterType<DataContext>()
                .As<DbContext>();
            builder.RegisterType<ProductRepository>()
                    .As<Irepository<Product>>()
                    .AsSelf();
            builder.RegisterType<ProductController>();
            builder.RegisterType<TestController>();
            config.Services.Replace(typeof(IHttpControllerActivator),
                new customHttpCotrollerActivator(builder.Build()));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        
            
        
        }
    }
}
