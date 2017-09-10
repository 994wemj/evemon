namespace EVEMon.XmlGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invControlTowerResourcePurposes
    {
        [Key]
        public byte purpose { get; set; }

        [StringLength(100)]
        public string purposeText { get; set; }
    }
}
