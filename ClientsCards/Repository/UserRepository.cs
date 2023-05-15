using ClientsCards.Shared;

namespace ClientsCards.Repository
{
    public class UserRepository: IUsersRepository
    {
        private readonly UserContext _context;
        public UserRepository()
        {
            _context = new UserContext();

        }
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public IEnumerable<User> GetAll()
        {
            return _context.GetAll();
        }
    }
}
