using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class Income : IIncome
{
    private ModelsDbContext _context;

    public Income(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<IncomeModel> AddAsync(IncomeModel model)
    {
        EntityEntry<IncomeModel> result = await _context.Incomes.AddAsync(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        IncomeModel? income = await _context.Incomes.FindAsync(id);

        if (income == null)
        {
            return false;
        }

        _context.Incomes.Remove(income);

        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<IncomeModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Incomes
            .Where(income => income.UserId == userId)
            .ToListAsync();
    }

    public async Task<IEnumerable<IncomeModel>> GetByCategoryIdAsync(int categoryId)
    {
        return await _context.Incomes
            .Where(income => income.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<IEnumerable<IncomeModel>> GetBySourceIdAsync(int sourceId)
    {
        return await _context.Incomes
            .Where(income => income.SourceDestinationId == sourceId)
            .ToListAsync();
    }

    public async Task<IncomeModel> UpdateAsync(IncomeModel model)
    {
        EntityEntry<IncomeModel> result = _context.Incomes.Update(model);

        await _context.SaveChangesAsync();

        return result.Entity;
    }
}
