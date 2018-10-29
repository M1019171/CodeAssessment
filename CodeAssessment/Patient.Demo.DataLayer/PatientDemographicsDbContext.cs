using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Demo.DataLayer
{
    public class PatientDemographicsDbContext : DbContext
    {
        public DbSet<Models.PatientDetails> PatientDetails { get; set; }


        public PatientDemographicsDbContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
