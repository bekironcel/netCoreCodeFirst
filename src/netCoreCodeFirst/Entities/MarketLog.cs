using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class MarketLog
    {
        public int Id { get; set; }
        public string HesapAdi { get; set; }
        public string UrunAdi { get; set; }
        public int? Fiyat { get; set; }
        public int? Adet { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
