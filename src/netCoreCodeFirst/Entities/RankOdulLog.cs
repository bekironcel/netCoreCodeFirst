using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class RankOdulLog
    {
        public int Id { get; set; }
        public string KarakterAdi { get; set; }
        public string Rank { get; set; }
        public int? Sira { get; set; }
        public string Odul { get; set; }
        public string Bonus { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
