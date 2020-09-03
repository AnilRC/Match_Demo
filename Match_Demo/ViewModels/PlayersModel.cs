using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Match_Demo.ViewModels
{
    public class PlayersModel
    {
        public PlayersModel()
        {
            this.Matches = new HashSet<MatchModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual ICollection<MatchModel> Matches { get; set; }
    }
}