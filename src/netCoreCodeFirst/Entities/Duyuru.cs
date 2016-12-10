using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class Duyuru
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public int? ResimTur { get; set; }

        public virtual DuyuruResim ResimTurNavigation { get; set; }
    }
}
