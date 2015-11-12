using System.Data.Entity;

namespace Repository
{
    public class Document : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DocumentContext : DbContext
    {
        public DbSet<Document> documents { get; set; }
    }

}
