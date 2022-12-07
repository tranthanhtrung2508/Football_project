using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football_project.Models;

namespace Football_project.Controllers
{
    public class TeamsController : Controller
    {
        CompanyDBContext db = new CompanyDBContext();
        // GET: Teams
        public ActionResult Index()
        {
            List<Team> teams = db.Teams.ToList();
            return View(teams);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Team t)
        {
            db.Teams.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Team team = db.Teams.Where(row => row.TeamID == id).FirstOrDefault();
            return View(team);
        }
        [HttpPost]
        public ActionResult Edit(Team t)
        {
            Team team = db.Teams.Where(row => row.TeamID == t.TeamID).FirstOrDefault();

            //Update
            team.TeamName = t.TeamName;
            team.Amount = t.Amount;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Team team = db.Teams.Where(row => row.TeamID == id).FirstOrDefault();
            return View(team);
        }
        [HttpPost]
        public ActionResult Delete(int id, Team t)
        {
            Team team = db.Teams.Where(row => row.TeamID == id).FirstOrDefault();
            db.Teams.Remove(team);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}