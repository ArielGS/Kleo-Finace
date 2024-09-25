namespace Kleo_Finaces.Models;

public class OutcomeModel : MovementBase
{
    public int SourceOriginId { get; set; }
    public SourceModel SourceOrigin { get; set; } = new SourceModel();
    public int? BudgetId { get; set; }
    public BudgetModel Budget { get; set; } = new BudgetModel();
    public int CategoryId { get; set; }
}