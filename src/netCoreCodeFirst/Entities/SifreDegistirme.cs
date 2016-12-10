using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class SifreDegistirme
    {
        public int Id { get; set; }
        public int? VtAccountId { get; set; }
        public string YeniSifre { get; set; }
        public string Guid { get; set; }
        public bool? OnayYapildimi { get; set; }
        public DateTime? DegismeTarihi { get; set; }
    }
}
