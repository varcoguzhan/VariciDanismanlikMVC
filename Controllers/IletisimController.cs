using Microsoft.AspNetCore.Mvc;

namespace VariciDanismanlikMVC.Controllers
{
    public class IletisimController: Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}