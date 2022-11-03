using System.Collections.Generic;

namespace AuthentificationService
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByLogin(string login);
    }
}
