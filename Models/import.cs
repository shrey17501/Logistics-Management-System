namespace logistics.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("import")]
    public partial class import
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string county { get; set; }

        [Column("shoes type")]
        [Required]
        [StringLength(50)]
        public string shoes_type { get; set; }

        [Column("brand name")]
        [Required]
        [StringLength(50)]
        public string brand_name { get; set; }
    }
}
