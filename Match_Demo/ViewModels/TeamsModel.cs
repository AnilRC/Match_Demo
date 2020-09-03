using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Match_Demo.ViewModels
{
    public class TeamsModel
    {
        public TeamsModel()
        {
            this.Matches = new HashSet<MatchModel>();
            this.Matches1 = new HashSet<MatchModel>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<MatchModel> Matches { get; set; }
        public virtual ICollection<MatchModel> Matches1 { get; set; }
    }
}