using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class TlSilkEpin
    {
        public TlSilkEpin()
        {
            TlEpinLog = new HashSet<TlEpinLog>();
        }

        public int Id { get; set; }
        public int? Miktar { get; set; }
        public string EpinKod { get; set; }
        public int? Point { get; set; }
        public int? Turu { get; set; }

        public virtual ICollection<TlEpinLog> TlEpinLog { get; set; }
        public virtual TlSilkTur TuruNavigation { get; set; }
    }
}
