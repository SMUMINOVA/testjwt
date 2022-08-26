using JWT.Models;

namespace JWT.Services
{
    public interface IJWTManagerRepository
    {
        public Tokens Authenticate(User users);
    }
}
