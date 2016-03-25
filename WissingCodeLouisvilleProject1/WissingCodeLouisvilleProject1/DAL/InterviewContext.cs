using WissingCodeLouisvilleProject1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WissingCodeLouisvilleProject1.DAL
{
    public class InterviewContext : DbContext
    {

        public InterviewContext() : base("InterviewContext")
        {
        }

        
        public DbSet<Interview> Interviews { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}