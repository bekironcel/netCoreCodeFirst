using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class SiteBolumAcKapa
    {
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public string BolumAd { get; set; }
        public bool? Aktif { get; set; }
    }
}
