using Identity_and_Data_Protection.Data;
using Identity_and_Data_Protection.Model.Entities;
using Microsoft.AspNetCore.Identity;

namespace Identity_and_Data_Protection.Helpers
{
    public class UserService
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(AppDbContext context, IPasswordHasher<User> passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> RegisterUser(string email,  string password)
        {
            var user = new User { Email = email };

            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
