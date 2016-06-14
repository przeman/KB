using KB.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View(new ArticlesRepo().ArticlesGetAll());
        }
        public ActionResult Details(int? id=0)
        {
            return View(new ArticlesRepo().ArticlesgetByID(id.Value));
        }
    }
}