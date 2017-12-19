namespace EasyTravelWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        public int cityID { get; set; }

        [Required]
        [StringLength(50)]
        public string cityName { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }
    }
}
