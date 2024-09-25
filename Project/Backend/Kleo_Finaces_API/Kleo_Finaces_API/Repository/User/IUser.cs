using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IUser
{
    Task<UserModel> AddAsync(UserModel model);
    Task<UserModel> UpdateAsync(UserModel model);
    Task<IEnumerable<UserModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
