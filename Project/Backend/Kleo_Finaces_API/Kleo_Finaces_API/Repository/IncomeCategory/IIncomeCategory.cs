using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface IIncomeCategory
{
    Task<IncomeCategoryModel> AddAsync(IncomeCategoryModel model);
    Task<IncomeCategoryModel> UpdateAsync(IncomeCategoryModel model);
    Task<IEnumerable<IncomeCategoryModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
