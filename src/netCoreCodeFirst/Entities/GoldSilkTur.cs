using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class GoldSilkTur
    {
        public GoldSilkTur()
        {
            MagazaSilkGold = new HashSet<MagazaSilkGold>();
        }

        public int Id { get; set; }
        public string SilkTur { get; set; }

        public virtual ICollection<MagazaSilkGold> MagazaSilkGold { get; set; }
    }
}
