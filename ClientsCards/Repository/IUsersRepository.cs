using ClientsCards.Shared;

namespace ClientsCards.Repository
{
    public interface IUsersRepository
    {
        public IEnumerable<User> GetAll();
    }
}
