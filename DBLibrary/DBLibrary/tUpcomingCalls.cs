namespace DBLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tUpcomingCalls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ClientID { get; set; }

        public DateTime? CallDate { get; set; }

        public int? Response { get; set; }

        [StringLength(200)]
        public string CallAbout { get; set; }
    }
}
