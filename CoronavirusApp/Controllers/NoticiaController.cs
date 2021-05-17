using CoronavirusApp.Models;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace CoronavirusApp.Controllers
{
    public class NoticiaController : Controller
    {
        public ActionResult Index(int? page)
        {
            NoticiaParser parser = new NoticiaParser();

            return View(parser.ObtenerNoticias().ToPagedList(page ?? 1, 5));
        }
    }
}