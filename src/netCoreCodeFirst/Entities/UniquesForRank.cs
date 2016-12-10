using System;
using System.Collections.Generic;

namespace netCoreCodeFirst.Entities
{
    public partial class UniquesForRank
    {
        public int MobId { get; set; }
        public string MobCode { get; set; }
        public string MobName { get; set; }
        public int Point { get; set; }
    }
}
