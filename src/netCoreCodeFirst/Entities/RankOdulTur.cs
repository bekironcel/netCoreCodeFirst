using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class RankOdulTur
    {
        public RankOdulTur()
        {
            RankOdulOdulTurNavigation = new HashSet<RankOdul>();
            RankOdulOdulTur2Navigation = new HashSet<RankOdul>();
        }

        public int Id { get; set; }
        public string Turu { get; set; }

        public virtual ICollection<RankOdul> RankOdulOdulTurNavigation { get; set; }
        public virtual ICollection<RankOdul> RankOdulOdulTur2Navigation { get; set; }
    }
}
