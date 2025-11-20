using System.Net.Http.Json;
using Core.Modeller;

namespace Genbrugsmarked.Service;

public class LoginService : ILoginService
{
    private readonly HttpClient _client;
    private const string LoginEndpoint = "http://localhost:5127/api/User/login";
    private const string UserEndpoint = "http://localhost:5127/api/User";

    public LoginService(HttpClient client)
    {
        _client = client;
    }

    public async Task<User?> Login(UserLogin login)
    {
        if (login == null)
        {
            return null;
        }

        var response = await _client.PostAsJsonAsync(LoginEndpoint, login);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var userId = await response.Content.ReadFromJsonAsync<int>();
        if (userId == 0)
        {
            return null;
        }

        return await _client.GetFromJsonAsync<User>($"{UserEndpoint}/{userId}");
    }
}