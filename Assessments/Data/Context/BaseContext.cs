using Data.Models;
using System.Data.Entity;

namespace Data.Context
{
    class BaseContext : DbContext
    {
        public DbSet<Criteria> Criteria { get; set; }
        public DbSet<Phase> Phase { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Assessment> Assessment { get; set; }
        public BaseContext() : base(@"Data Source=192.168.0.126;Initial Catalog=DbAssessments;Persist Security Info=True;User ID=Assessments;Password=assessments@123")
        {

        }
    }
}
