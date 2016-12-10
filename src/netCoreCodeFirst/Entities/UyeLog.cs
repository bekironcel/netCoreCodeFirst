using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class UyeLog
    {
        public int Id { get; set; }
        public string HesapId { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string GizliYanit { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
