using System;
using System.Threading.Tasks;
using Core.Modeller;

namespace Genbrugsmarked.Service;

public interface IUserSessionService
{
    event Action? OnChange;
    User? CurrentUser { get; }
    Task InitializeAsync();
    Task SetUserAsync(User user);
    Task LogoutAsync();
}

