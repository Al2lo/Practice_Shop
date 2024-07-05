
using PracticeShop.DAL.Entities;

namespace PracticeShop.BLL.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
