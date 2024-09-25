using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IBudget
{
    Task<BudgetModel> AddAsync(BudgetModel model);
    Task<BudgetModel> UpdateAsync(BudgetModel model);
    Task<IEnumerable<BudgetModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
