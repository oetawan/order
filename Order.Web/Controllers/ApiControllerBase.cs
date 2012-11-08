using Order.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Order.Web.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected IOrderUow Uow { get; set; }
    }
}