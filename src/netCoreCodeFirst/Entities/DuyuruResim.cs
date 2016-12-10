using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class DuyuruResim
    {
        public DuyuruResim()
        {
            Duyuru = new HashSet<Duyuru>();
        }

        public int Id { get; set; }
        public string ResimYol { get; set; }

        public virtual ICollection<Duyuru> Duyuru { get; set; }
    }
}
