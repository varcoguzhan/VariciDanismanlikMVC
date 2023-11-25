using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VariciDanismanlikMVC.Models;

namespace VariciDanismanlikMVC.Controllers
{
  
    public class ServiceController : Controller
    {
        

        // public IActionResult Services()
        // {
        //     var service= new Service();
        //     service.Id=1;
        //     service.Image="Eğitim.jpg";
        //     service.Description="ecoebfo";
        //     return View(service);
        // }
        public IActionResult Services()
        {
            
            {
                var servisler = new List<Service>()
            {
            new Service() { Id=1,Action="Management", Image="Yönetim.jpg",Title="Yönetim Danışmanlığı" ,Description="Some quick example text to build on the card title and make up the bulk"},
            new Service() { Id=1,Action="Finance", Image="Finance.jpg",Title="Finans Danışmanı", Description="Some quick example text to build on the card title and make up the bulk"},
            new Service() { Id=1,Action="Education", Image="Eğitim.jpg", Title="Eğitim Danışmanlığı", Description="Some quick example text to build on the card title and make up the bulk"},
            };
                return View(servisler);
            }
            
        }
            public IActionResult Management()
            {

                return View();
            }
            public IActionResult Finance()
            {

                return View();
            }
            public IActionResult Education()
            {

                return View();
            }
            }
}