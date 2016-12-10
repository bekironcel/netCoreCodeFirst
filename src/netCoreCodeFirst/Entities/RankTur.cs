using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class RankTur
    {
        public RankTur()
        {
            RankOdul = new HashSet<RankOdul>();
            RankSureAyar = new HashSet<RankSureAyar>();
        }

        public int Id { get; set; }
        public string Turu { get; set; }

        public virtual ICollection<RankOdul> RankOdul { get; set; }
        public virtual ICollection<RankSureAyar> RankSureAyar { get; set; }
    }
}
