using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class Karaktergorselleri
    {
        public int Id { get; set; }
        public int? Karakterid { get; set; }
        public string Imgid { get; set; }
    }
}
