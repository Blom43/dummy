using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
{

    public class SHAREitMasterDetailPage1MasterMenuItem
    {
        public SHAREitMasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(SHAREitMasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}