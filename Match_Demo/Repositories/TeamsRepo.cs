using Match_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Match_Demo.Repositories
{
    public class TeamsRepo
    {
        MatchDBContext db;
        public TeamsRepo()
        {
            db = new MatchDBContext();
        }
        public IEnumerable<SelectListItem> GetAllTeamNames()
        {
            var TeamName = new List<SelectListItem>();
            TeamName = (from obj in db.Teams.AsEnumerable()
                          select new SelectListItem()
                          {
                              Text = obj.TeamName,
                              Value = obj.Id.ToString(),
                              Selected = true
                          }).ToList();
            return TeamName;
        }
        
    }
}