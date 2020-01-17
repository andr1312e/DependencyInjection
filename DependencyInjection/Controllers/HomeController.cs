using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using DependencyInjection.Infrastructure;

namespace DependencyInjection.Controllers
{
    public class HomeController:Controller
    {
        public IRepostitory Repostitory { get;  } =TypeBroker.Repostitory;
        public ViewResult Index() => View(Repostitory.Products);
    }
}
