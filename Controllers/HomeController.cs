﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VariciDanismanlikMVC.Models;

namespace VariciDanismanlikMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    // public IActionResult Contact()
    // {
    //     return View();
    // }
    public IActionResult Services()
    {

        return View();
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
