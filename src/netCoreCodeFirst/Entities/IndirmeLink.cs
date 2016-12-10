using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class IndirmeLink
    {
        public int Id { get; set; }
        public string Saglayici { get; set; }
        public string Link { get; set; }
        public string DosyaBoyutu { get; set; }
        public string DosyaAdi { get; set; }
    }
}
