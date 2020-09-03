using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Match_Demo.ViewModels
{
    public class MatchModel
    {
        public int Id { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public Nullable<int> TeamOneId { get; set; }
        public Nullable<int> TeamTwoId { get; set; }
        public string MatchName { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> MatchDate { get; set; }
        public string Address { get; set; }

        public virtual PlayersModel Player { get; set; }
        public virtual TeamsModel Team { get; set; }
        public virtual TeamsModel Team1 { get; set; }
    }
}