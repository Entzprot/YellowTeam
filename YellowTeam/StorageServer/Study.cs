using Repository;
using System;
using System.Data.Entity;

namespace Repository
{
    public class Study : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StudyContext : DbContext
    {
        public DbSet<Study> studies { get; set; }
    }

}
