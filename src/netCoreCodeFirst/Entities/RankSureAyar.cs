using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class RankSureAyar
    {
        public int Id { get; set; }
        public int? Turu { get; set; }
        public string Saat { get; set; }
        public int? KacGun { get; set; }
        public DateTime? BaslangicTar { get; set; }
        public bool? IlkGunKontrol { get; set; }
        public DateTime? SifirlanmaTarihi { get; set; }

        public virtual RankTur TuruNavigation { get; set; }
    }
}
