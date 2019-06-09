using System;
using Microsoft.AspNetCore.Mvc;

namespace bus.Controllers
{
    public class GestaoController : Controller
    {
        public IActionResult index(){
            return View();
        }
    }
}