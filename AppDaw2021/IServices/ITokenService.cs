using AppDaw2021.Entities;

namespace AppDaw2021.IServices
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
