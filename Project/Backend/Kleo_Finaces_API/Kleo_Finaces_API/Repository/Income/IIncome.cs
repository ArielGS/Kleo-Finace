using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IIncome
{
    Task<IncomeModel> AddAsync(IncomeModel model);
    Task<IncomeModel> UpdateAsync(IncomeModel model);
    Task<IEnumerable<IncomeModel>> GetByUserIdAsync(int userId);
    Task<IEnumerable<IncomeModel>> GetByCategoryIdAsync(int categoryId);
    Task<IEnumerable<IncomeModel>> GetBySourceIdAsync(int sourceId);
    Task<bool> DeleteAsync(int id);
}
