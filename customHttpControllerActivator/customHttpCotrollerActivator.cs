using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Autofac;
using Autofac.Core;

namespace depenDencyInjectionWIthAutoFac.customHttpControllerActivator
{
    public class customHttpCotrollerActivator : IHttpControllerActivator
    {
        private IContainer _container;
        public customHttpCotrollerActivator(IContainer container) {
            this._container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor 
            controllerDescriptor, Type controllerType)
       {

            return _container.Resolve(controllerType) as IHttpController;

        }
    }
}