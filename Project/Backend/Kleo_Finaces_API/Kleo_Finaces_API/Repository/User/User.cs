using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class User : IUser
{
    private ModelsDbContext _context;

    public User(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<UserModel> AddAsync(UserModel model)
    {
        EntityEntry<UserModel> result = await _context.Users.AddAsync(model);

        await _context.SaveChangesAsync(); 

        return result.Entity; 
    }

    public async Task<bool> DeleteAsync(int id)
    {
        UserModel? user = await _context.Users.FindAsync(id);

        if (user == null)
        {
            return false; 
        }

        _context.Users.Remove(user);

        await _context.SaveChangesAsync();

        return true; 
    }

    public async Task<IEnumerable<UserModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Users
            .Where(user => user.Id == userId) 
            .ToListAsync();
    }

    public async Task<UserModel> UpdateAsync(UserModel model)
    {
        EntityEntry<UserModel> result = _context.Users.Update(model);

        await _context.SaveChangesAsync(); 

        return result.Entity;
    }
}
