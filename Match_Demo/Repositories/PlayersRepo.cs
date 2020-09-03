using Match_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Match_Demo.Repositories
{
    public class PlayersRepo
    {
        MatchDBContext db;
        public PlayersRepo()
        {
            db = new MatchDBContext();
        }
        public IEnumerable<SelectListItem> GetAllPlayersNames()
        {
            var PlayerName = new List<SelectListItem>();
            PlayerName = (from obj in db.Players.AsEnumerable()
                        select new SelectListItem()
                        {
                            Text = obj.Name,
                            Value = obj.Id.ToString(),
                            Selected = true
                        }).ToList();
            return PlayerName;
        }
        //It is optional now..
        public IEnumerable<SelectListItem> GetAllPlayerTypes()
        {
            var PlayerType = new List<SelectListItem>();
            PlayerType = (from obj in db.Players.AsEnumerable()
                        select new SelectListItem()
                        {
                            Text = obj.Type,
                            Value = obj.Id.ToString(),
                            Selected = true
                        }).ToList();
            return PlayerType;
        }
    }
}