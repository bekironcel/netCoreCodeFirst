using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class Kullanicilar
    {
        public int Id { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
    }
}
