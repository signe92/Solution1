using Core.Klasser;
using System;
using System.Collections.Generic;
using Core.Modeller;

namespace GenbrugsmarkedAPI.Repositories
{
    public interface IUserRepository
    {
        User? GetUserById(int id);

        Task<User?> Login(string email, string password);

    }
}