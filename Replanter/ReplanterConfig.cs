﻿using Microsoft.Xna.Framework;
using StardewLib;

namespace Replanter
{
    internal class ReplanterConfig : IConfig
    {
        public string KeyBind { get; set; } = "J";

        public bool Free { get; set; }

        public int SeedDiscount { get; set; }

        public string WhoChecks { get; set; } = "spouse";

        public bool EnableMessages { get; set; } = true;

        // If negative, don't add to inventory.
        public float CostPerCropHarvested { get; set; } = 0.5f;

        public bool SellHarvestedCropsImmediately { get; set; }

        public bool WaterCrops { get; set; }

        public string IgnoreList { get; set; } = "591|593|595|597|376";

        public string AlwaysSellList { get; set; } = "";

        public string NeverSellList { get; set; } = "";

        // The X, Y coordinates of a chest, into which surplus items can be deposited.  The farmers inventory will be tried first, unless bypassInventory is true.
        public Vector2 ChestCoords { get; set; } = new Vector2(70f, 14f);

        // Whether to bypass the user's inventory and try depositing to the chest first.  Will fall back to the inventory if no chest is present.
        public bool BypassInventory { get; set; }

        public string ChestDefs { get; set; } = "613,70,14|643,73,14";

        public bool ClearDeadPlants { get; set; } = true;

        public bool SmartReplantingEnabled { get; set; } = true;
    }
}
