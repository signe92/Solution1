using Core.Modeller;

namespace Genbrugsmarked.Service;

public interface ILoginService
{
    Task<User?> Login(UserLogin login);
}