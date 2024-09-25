namespace Kleo_Finaces.Repository;

public interface IRepository
{
    public IBudget budget { get; }
    public ISource source { get; }
    public IIncome income { get; }
    public IOutcome outcome { get; }
    public ITransfer transfer { get; }
    public IIncomeCategory incomeCategory { get; }
    public IOutcomeCategory outcomeCategory { get; } 
    public IUser user { get; }
}
