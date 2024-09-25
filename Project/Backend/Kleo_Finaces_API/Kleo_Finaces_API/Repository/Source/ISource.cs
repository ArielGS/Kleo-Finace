using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface ISource
{
    Task<SourceModel> AddAsync(SourceModel model);
    Task<SourceModel> UpdateAsync(SourceModel model);
    Task<IEnumerable<SourceModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
