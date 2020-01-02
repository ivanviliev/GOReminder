namespace DBLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbModel : DbContext
    {
        public dbModel()
            : base("name=dbModel")
        {
        }

        public virtual DbSet<tClients> tClients { get; set; }
        public virtual DbSet<tContactPhone> tContactPhone { get; set; }
        public virtual DbSet<tUpcomingCalls> tUpcomingCalls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
