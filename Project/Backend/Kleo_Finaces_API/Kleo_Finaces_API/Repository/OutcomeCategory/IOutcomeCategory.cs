using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IOutcomeCategory
{
    Task<OutcomeCategoryModel> AddAsync(OutcomeCategoryModel model);
    Task<OutcomeCategoryModel> UpdateAsync(OutcomeCategoryModel model);
    Task<IEnumerable<OutcomeCategoryModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
