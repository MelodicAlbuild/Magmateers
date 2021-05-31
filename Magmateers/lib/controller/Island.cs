using Magmateers.lib.data;
using Magmateers.lib.storage;
using System;
using System.Collections.Generic;
using System.Text;
using Magmateers.lib.scripts;
using Magmateers.lib.manager;

namespace Magmateers.lib.controller
{
    class Island
    {
        public Island()
        {
            new MagmaDict();
            new ImportHandler();
            new ExportHandler();

            foreach(KeyValuePair<Item,GUID> item in ExportHandler.magmaItems)
            {
                MagmaLog.Log(item.Key.ToString());
            }

            // Run Items
            if (GlobalStorage.managerData[0].enabled)
            {
                new MagmaItems();
            }

            MagmaDict.ReturnAllData();
        }
    }
}
