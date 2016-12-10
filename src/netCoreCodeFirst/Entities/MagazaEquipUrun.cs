using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class MagazaEquipUrun
    {
        public int Id { get; set; }
        public string ItemAdi { get; set; }
        public string ItemKodu { get; set; }
        public int? Adet { get; set; }
        public int? Arti { get; set; }
        public int? Fiyat { get; set; }
        public DateTime? UrunEklenmeTarihi { get; set; }
        public string Guid { get; set; }
        public string Resim { get; set; }
    }
}
