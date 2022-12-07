using Football_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football_project.Models;

namespace Football_project.Controllers
{
    public class MatchsController : Controller
    {
        CompanyDBContext db = new CompanyDBContext();
        // GET: Matchs
        public ActionResult Index()
        {
            List<Match> matches = db.Matchs.ToList();
            return View(matches);
        }
        public ActionResult Detail(int id)
        {
            List<Goal> goals = db.Goals.Where(row => row.MatchID == id).ToList();
            return View(goals);
        }
    }
}