using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Match_Demo.ViewModels
{
    public class MatchDetailModel
    {
        public int MatchDetailId { get; set; }
        public Nullable<int> MatchId { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public string PlayerType { get; set; }
        public string Position { get; set; }
        public string TeamId { get; set; }

        public virtual MatchModel Match { get; set; }
    }
}