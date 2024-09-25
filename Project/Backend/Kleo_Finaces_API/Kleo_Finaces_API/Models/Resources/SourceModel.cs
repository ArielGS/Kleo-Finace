namespace Kleo_Finaces.Models;

public class SourceModel : ResourceBase
{
    public SourceTypeModel Type { get; set; } = new SourceTypeModel();
    public bool IncludeInTotal { get; set; }
}