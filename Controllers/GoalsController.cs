using Football_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football_project.Models;

namespace Football_project.Controllers
{
    public class GoalsController : Controller
    {
        // GET: Goals
        public ActionResult Index()
        {
            CompanyDBContext db = new CompanyDBContext();
            List<Goal> goals = db.Goals.ToList();
            return View(goals);
        }
    }
}