using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class TlEpinLog
    {
        public int Id { get; set; }
        public int? HesapId { get; set; }
        public string HesapAdi { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public string Aciklama { get; set; }
        public int? EpinId { get; set; }
        public string Tur { get; set; }

        public virtual TlSilkEpin Epin { get; set; }
    }
}
