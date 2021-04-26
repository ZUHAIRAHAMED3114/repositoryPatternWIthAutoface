using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using depenDencyInjectionWIthAutoFac.Models;

namespace depenDencyInjectionWIthAutoFac.Controllers
{
    public class TestController : ApiController
    {
        public TestController(ProductRepository ProducteRepostory) { 
        }

        public string getName() {
            return "zuhair";
        }
    }
}
