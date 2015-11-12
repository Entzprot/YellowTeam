using System;
using System.Data.Entity;

namespace Repository
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }
    }

}
