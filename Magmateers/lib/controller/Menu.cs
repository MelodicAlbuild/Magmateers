using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Magmateers.lib.manager;
using Magmateers.lib.scripts;

namespace Magmateers.lib.controller
{
    class Menu
    {
        public Menu()
        {
            var lastWrite = File.GetLastWriteTime(typeof(Magmateers).Assembly.Location);
            MagmaLog.Log($"[Magmateers | Main]: Magmateers loaded: {Magmateers.version}, build time: {lastWrite.ToShortTimeString()}", true);

            new GlobalManager();
            new GlobalStorage();

            MagmaLog.Log("[Magmateers | Menu]: Managers Loaded without Error. Version Tags are now Enabled");
        }
    }
}
