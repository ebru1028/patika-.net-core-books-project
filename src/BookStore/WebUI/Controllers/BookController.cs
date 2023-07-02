using Data;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class BookController : Controller
    {
        private readonly DataContext _context;
        // GET
        public IActionResult List()
        {
            return View();
        }
    }
}