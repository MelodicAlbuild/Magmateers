using Magmateers.lib.scripts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magmateers.lib.data
{
    class ExportHandler
    {
        public static readonly Dictionary<Item, GUID> magmaItems = new Dictionary<Item, GUID>();
        public static readonly Dictionary<Recipe, GUID> magmaRecipes = new Dictionary<Recipe, GUID>();
        public static readonly Dictionary<Modifier, string> magmaModifiers = new Dictionary<Modifier, string>();
        public static readonly Dictionary<Category, GUID> magmaCategories = new Dictionary<Category, GUID>();
        public static readonly Dictionary<Deposit, string> magmaDeposits = new Dictionary<Deposit, string>();
        public static readonly Dictionary<Module, GUID> magmaModules = new Dictionary<Module, GUID>();
        public static readonly Dictionary<Station, GUID> magmaStations = new Dictionary<Station, GUID>();
        public static readonly Dictionary<Schematic, int> magmaSchematics = new Dictionary<Schematic, int>();
        public ExportHandler()
        {
            Export();
            MagmaLog.Log("[Export Handler]: Export Complete");
        }
        private void Export()
        {
            MagmaLog.Log("[Export Handler]: Itemizing Items...");
            foreach (Item item in ImportHandler.imports.items)
            {
                magmaItems[item] = GUID.Parse(item.guid);
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Items...");
            MagmaLog.Log("[Export Handler]: Itemizing Recipes...");

            foreach (Recipe item in ImportHandler.imports.recipes)
            {
                magmaRecipes[item] = GUID.Parse(item.itemID);
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Recipes...");
            MagmaLog.Log("[Export Handler]: Itemizing Modifiers...");

            foreach (Modifier item in ImportHandler.imports.modifiers)
            {
                magmaModifiers[item] = item.modification_type;
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Modifiers...");
            MagmaLog.Log("[Export Handler]: Itemizing Categories...");

            foreach (Category item in ImportHandler.imports.categories)
            {
                magmaCategories[item] = GUID.Parse(item.guid);
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Categories...");
            MagmaLog.Log("[Export Handler]: Itemizing Deposits...");

            foreach (Deposit item in ImportHandler.imports.deposits)
            {
                magmaDeposits[item] = item.replaced_item;
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Deposits...");
            MagmaLog.Log("[Export Handler]: Itemizing Modules...");

            foreach (Module item in ImportHandler.imports.modules)
            {
                magmaModules[item] = GUID.Parse(item.guid);
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Modules...");
            MagmaLog.Log("[Export Handler]: Itemizing Stations...");

            foreach (Station item in ImportHandler.imports.stations)
            {
                magmaStations[item] = GUID.Parse(item.guid);
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Stations...");
            MagmaLog.Log("[Export Handler]: Itemizing Schematics...");

            foreach (Schematic item in ImportHandler.imports.schematics)
            {
                magmaSchematics[item] = item.id;
            }

            MagmaLog.Log("[Export Handler]: Done Itemizing Schematics...");
        }
    }
}
