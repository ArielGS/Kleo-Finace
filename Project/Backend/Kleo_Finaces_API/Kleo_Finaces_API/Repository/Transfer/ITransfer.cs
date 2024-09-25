using Kleo_Finaces.Models;

namespace Kleo_Finaces.Repository;

public interface ITransfer
{
    Task<TransferModel> AddAsync(TransferModel model);
    Task<TransferModel> UpdateAsync(TransferModel model);
    Task<IEnumerable<TransferModel>> GetByUserIdAsync(int userId);
    Task<bool> DeleteAsync(int id);
}
