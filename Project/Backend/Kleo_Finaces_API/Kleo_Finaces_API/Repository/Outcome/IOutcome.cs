using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IOutcome
{
    Task<OutcomeModel> AddAsync(OutcomeModel model);
    Task<OutcomeModel> UpdateAsync(OutcomeModel model);
    Task<IEnumerable<OutcomeModel>> GetByUserIdAsync(int userId);
    Task<IEnumerable<OutcomeModel>> GetByCategoryIdAsync(int categoryId);
    Task<IEnumerable<OutcomeModel>> GetBySourceIdAsync(int sourceId);
    Task<IEnumerable<OutcomeModel>> GetByBudgetIdAsync(int budgetId);
    Task<bool> DeleteAsync(int id);
}
