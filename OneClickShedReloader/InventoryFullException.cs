﻿using System;

namespace BitwiseJonMods.OneClickShedReloader
{
    class InventoryFullException: Exception
    {
        public int NumItemsHarvestedBeforeFull { get; set; }

        public InventoryFullException()
            : base() { }

        public InventoryFullException(string message)
            : base(message) { }

        public InventoryFullException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public InventoryFullException(string message, Exception innerException)
            : base(message, innerException) { }

        public InventoryFullException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
