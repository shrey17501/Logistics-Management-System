namespace logistics.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("export")]
    public partial class export
    {
        public int id { get; set; }

        [Column("shoes type")]
        [StringLength(50)]
        public string shoes_type { get; set; }

        [Column("brand name")]
        [StringLength(50)]
        public string brand_name { get; set; }

        [Column("export address")]
        [StringLength(50)]
        public string export_address { get; set; }
    }
}
