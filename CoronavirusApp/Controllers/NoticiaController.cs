using CoronavirusApp.Models;
using System.Web.Mvc;

namespace CoronavirusApp.Controllers
{
    public class NoticiaController : Controller
    {
        public ActionResult Index()
        {
            NoticiaParser parser = new NoticiaParser();

            return View(parser.ObtenerNoticias());
        }
    }
}