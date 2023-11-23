using Microsoft.AspNetCore.Mvc;
using VariciDanismanlikMVC.Data;

namespace VariciDanismanlikMVC.Controllers
{
    public class IletisimController: Controller
    {
        private readonly IletisimContext _context;
        public IletisimController(IletisimContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(Iletisim model)
        {
            _context.Iletisimler.Add(model);
            _context.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }
    }

 
}