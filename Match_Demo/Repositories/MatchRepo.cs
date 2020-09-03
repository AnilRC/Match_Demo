using Match_Demo.Models;
using Match_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Match_Demo.Repositories
{
    public class MatchRepo
    {
        MatchDBContext db;
        public MatchRepo()
        {
            db = new MatchDBContext();
        }
        public bool Save(MatchModel matchModel)
        {
            Match match = new Match();
            match.MatchDate = matchModel.MatchDate;
            match.MatchName =matchModel.MatchName;
            match.StartTime = matchModel.StartTime;
            match.TeamOneId = matchModel.TeamOneId;
            match.TeamTwoId = matchModel.TeamTwoId;
            match.Address = matchModel.Address;
           
            db.Matches.Add(match);
            db.SaveChanges();
            int matchId = match.Id;

            foreach (var item in matchModel.MatchDetails)
            {
                MatchDetail matchDetails = new MatchDetail();
                matchDetails.MatchId = matchId;
                matchDetails.PlayerId = item.PlayerId;
                matchDetails.PlayerType = item.PlayerType;
                matchDetails.Position = item.Position;
                matchDetails.TeamId = item.TeamId;
                
                db.MatchDetails.Add(matchDetails);
                db.SaveChanges();

                
            }
            return true;
        }
    }
}