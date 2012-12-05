using System.ComponentModel;
using EVEMon.Common.Attributes;

namespace EVEMon.Common.SettingsObjects
{
    public enum AssetColumn
    {
        None = -1,

        [Header("Item")]
        [Description("Item (Name)")]
        ItemName = 0,

        [Header("Quantity")]
        [Description("Quantity")]
        Quantity = 1,

        [Header("Unit Price")]
        [Description("Unit Price")]
        UnitaryPrice = 2,

        [Header("Total Price")]
        [Description("Total Price")]
        TotalPrice = 3,

        [Header("Volume (m�)")]
        [Description("Total Volume")]
        Volume = 4,

        [Header("Blueprint type")]
        [Description("Blueprint Type (Original or Copy)")]
        BlueprintType = 5,

        [Header("Group")]
        [Description("Item Group")]
        Group = 6,

        [Header("Category")]
        [Description("Item Category")]
        Category = 7,

        [Header("Container")]
        [Description("Container (Containing the item)")]
        Container = 8,

        [Header("Flag")]
        [Description("Item Flag")]
        Flag = 9,

        [Header("Location")]
        [Description("Location (Station or Solar System)")]
        Location = 10,

        [Header("Region")]
        [Description("Location (Region)")]
        Region = 11,

        [Header("System")]
        [Description("Location (Solar System)")]
        SolarSystem = 12,

        [Header("Path")]
        [Description("Location (Full)")]
        FullLocation = 13,

        [Header("Jumps")]
        [Description("Jumps (From character's last known location)")]
        Jumps = 14
    }
}