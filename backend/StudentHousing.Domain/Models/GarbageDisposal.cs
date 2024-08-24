namespace StudentHousing.Domain.Models;

public sealed class GarbageDisposal
{
    public required Guid Id { get; init; }

    public required GarbageType GarbageType { get; init; }
    
    public required DateTime DateOfDisposal { get; init; }
}