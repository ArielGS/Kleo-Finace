namespace Kleo_Finaces.Models;

public class TransferModel : MovementBase
{
    public int SourceOriginId { get; set; }
    public SourceModel SourceOrigin { get; set; } = new SourceModel();
    public int SourceDestinationId { get; set; }
    public SourceModel SourceDestination { get; set; } = new SourceModel();
}
