namespace EVEMon.XmlGenerator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invNames
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long itemID { get; set; }

        [Required]
        [StringLength(200)]
        public string itemName { get; set; }
    }
}
