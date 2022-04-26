﻿using WanderLost.Shared.Data;

namespace WanderLost.Client
{
    public class MerchantNotificationSetting
    {
        public bool NotifySpawn { get; set; }
        public HashSet<string> Cards { get; set; } = new();
        public HashSet<string> Rapports { get; set; } = new();
    }
}
