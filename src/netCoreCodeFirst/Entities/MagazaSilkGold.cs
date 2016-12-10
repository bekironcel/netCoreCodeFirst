using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class MagazaSilkGold
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public int? SilkGold { get; set; }
        public int? Bonus { get; set; }
        public int? SilkTur { get; set; }
        public int? Fiyat { get; set; }
        public string Guid { get; set; }

        public virtual GoldSilkTur SilkTurNavigation { get; set; }
    }
}
