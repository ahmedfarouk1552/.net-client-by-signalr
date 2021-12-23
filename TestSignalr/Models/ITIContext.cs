using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestSignalr.Models
{
    public partial class ITIContext : DbContext
    {
        public ITIContext()
            : base("name=ITIContext")
        {
        }

        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
