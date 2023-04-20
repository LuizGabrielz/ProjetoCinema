using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoCinema.Web.Models;

namespace ProjetoCinema.Web.Controllers;

public class FilmesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
