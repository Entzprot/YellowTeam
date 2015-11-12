
namespace Repository
{
    public interface IStock
    {
        IRepository<Document> DocumentDatabase { get; set; }
        IRepository<Study> StudyDatabase { get; set; }
        IRepository<User> UserDatabase { get; set; }
    }
}