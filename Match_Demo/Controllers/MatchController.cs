using Match_Demo.Models;
using Match_Demo.Repositories;
using Match_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Match_Demo.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        MatchDBContext db;
        public MatchController()
        {
            db = new MatchDBContext();
        }
        public ActionResult Index()
        {
            PlayersRepo playerRepo = new PlayersRepo();
            TeamsRepo teamRepo = new TeamsRepo();
           
            var playTeam = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(playerRepo.GetAllPlayersNames(), playerRepo.GetAllPlayerTypes(), teamRepo.GetAllTeamNames());
            return View(playTeam);
            
        }

        public JsonResult GetPlayerType(int Id)
        {
            string playerType = db.Players.Single(model => model.Id == Id).Type;
            return Json(playerType, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(MatchModel matchModel)
        {
            MatchRepo matchRepo = new MatchRepo();
            matchRepo.Save(matchModel);
            return Json("Your Data is Saved Successfully..", JsonRequestBehavior.AllowGet);
        }
    }
}