namespace Kleo_Finaces.Models;

public class IncomeModel : MovementBase
{
    public int SourceDestinationId { get; set; }
    public SourceModel SourceDestination { get; set; } = new SourceModel();
    public int CategoryId { get; set; }
    public IncomeCategoryModel Category { get; set; } = new IncomeCategoryModel();
}
