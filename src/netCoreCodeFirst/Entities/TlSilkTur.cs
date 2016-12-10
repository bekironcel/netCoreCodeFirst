using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class TlSilkTur
    {
        public TlSilkTur()
        {
            TlSilkEpin = new HashSet<TlSilkEpin>();
        }

        public int Id { get; set; }
        public string TlSilkTur1 { get; set; }

        public virtual ICollection<TlSilkEpin> TlSilkEpin { get; set; }
    }
}
