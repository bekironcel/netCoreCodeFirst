using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class RankOdul
    {
        public int Id { get; set; }
        public int? OdulTur { get; set; }
        public int? Miktar { get; set; }
        public int? OdulUnique { get; set; }
        public int? Sira { get; set; }
        public int? OdulTur2 { get; set; }
        public int? Miktar2 { get; set; }

        public virtual RankOdulTur OdulTurNavigation { get; set; }
        public virtual RankOdulTur OdulTur2Navigation { get; set; }
        public virtual RankTur OdulUniqueNavigation { get; set; }
    }
}
