using Magmateers.lib.scripts;
using Magmateers.lib.storage.scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magmateers.lib.storage
{
    class MagmaDict
    {
        public static readonly Dictionary<string, GUID> magmaRegistry = new Dictionary<string, GUID>();
        public MagmaDict()
        {
            MagmaLog.Log("[Dictionary Manager]: Dictionary Verified and Running, Continuing Init");
        }

        public static void ReturnAllData()
        {
            foreach (KeyValuePair<string, GUID> dict in magmaRegistry)
            {
                DictLog.Log("[Dictionary Manager]: Name: " + dict.Key + " | GUID: " + dict.Value + " has been Registered");
            }
        }
    }
}
