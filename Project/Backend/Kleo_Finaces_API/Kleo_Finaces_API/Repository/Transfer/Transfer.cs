using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class Transfer : ITransfer
{
    private ModelsDbContext _context;

    public Transfer(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<TransferModel> AddAsync(TransferModel model)
    {
        EntityEntry<TransferModel> result = await _context.Transfers.AddAsync(model);

        await _context.SaveChangesAsync(); 

        return result.Entity; 
    }

    public async Task<bool> DeleteAsync(int id)
    {
        TransferModel? transfer = await _context.Transfers.FindAsync(id);

        if (transfer == null)
        {
            return false; 
        }

        _context.Transfers.Remove(transfer);

        await _context.SaveChangesAsync();

        return true; 
    }

    public async Task<IEnumerable<TransferModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Transfers
            .Where(transfer => transfer.UserId == userId) 
            .ToListAsync();
    }

    public async Task<TransferModel> UpdateAsync(TransferModel model)
    {
        EntityEntry<TransferModel> result = _context.Transfers.Update(model);

        await _context.SaveChangesAsync(); 

        return result.Entity;
    }
}
