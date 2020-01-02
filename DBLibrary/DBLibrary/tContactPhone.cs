namespace DBLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tContactPhone")]
    public partial class tContactPhone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhoneId { get; set; }

        public int? ClientID { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string PhoneCode { get; set; }

        public int? Status { get; set; }
    }
}
