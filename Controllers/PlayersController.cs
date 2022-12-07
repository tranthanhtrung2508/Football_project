using Football_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Football_project.Models;

namespace Football_project.Controllers
{
    public class PlayersController : Controller
    {
        CompanyDBContext db = new CompanyDBContext();

        // GET: Players
        public ActionResult Index(string search = "")
        {
            //Search
            List<Player> players = db.Players.Where(row => row.PlayerName.Contains(search)).ToList();
            ViewBag.Search = search;
            return View(players);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Player p)
        {
            db.Players.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Player player = db.Players.Where(row => row.PlayerID == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public ActionResult Edit(Player p)
        {
            Player player = db.Players.Where(row => row.PlayerID == p.PlayerID).FirstOrDefault();

            //Update
            player.PlayerName = p.PlayerName;
            player.PlayerNumber = p.PlayerNumber;
            player.RoleName = p.RoleName;
            player.TeamName = p.TeamName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Player player = db.Players.Where(row => row.PlayerID == id).FirstOrDefault();
            return View(player);
        }
        [HttpPost]
        public ActionResult Delete(int id, Player p)
        {
            Player player = db.Players.Where(row => row.PlayerID == id).FirstOrDefault();
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}