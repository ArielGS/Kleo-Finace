using Kleo_Finaces.Data;
using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Kleo_Finaces.Repository;

public class Budget : IBudget
{
    private ModelsDbContext _context;

    public Budget(ModelsDbContext context)
    {
        _context = context;
    }

    public async Task<BudgetModel> AddAsync(BudgetModel model)
    {
        EntityEntry<BudgetModel> result = await _context.Budgets.AddAsync(model);

        await _context.SaveChangesAsync(); 

        return result.Entity; 
    }

    public async Task<bool> DeleteAsync(int id)
    {
        BudgetModel? budget = await _context.Budgets.FindAsync(id);

        if (budget == null)
        {
            return false; 
        }

        _context.Budgets.Remove(budget);

        await _context.SaveChangesAsync();

        return true; 
    }

    public async Task<IEnumerable<BudgetModel>> GetByUserIdAsync(int userId)
    {
        return await _context.Budgets
            .Where(budget => budget.UserId == userId) 
            .ToListAsync();
    }

    public async Task<BudgetModel> UpdateAsync(BudgetModel model)
    {
        EntityEntry<BudgetModel> result = _context.Budgets.Update(model);

        await _context.SaveChangesAsync(); 

        return result.Entity;
    }
}
