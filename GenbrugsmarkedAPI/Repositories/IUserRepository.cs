using Core.Klasser;
using System;
using System.Collections.Generic;
using Core.Modeller;

namespace GenbrugsmarkedAPI.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        
        
        User? GetUserById(int id);

        public Task<bool> Login(string email, string password);

    }
}