namespace StudentHousingApp.Models;
internal sealed class GarbageDisposal
{
    public required Guid Id { get; init; }

    public required GarbageType GarbageType { get; init; }

    public required DateTime DateOfDisposal { get; init; }

    public override string ToString()
    {
        return $"{GarbageType}: {DateOfDisposal:f}";
    }
}
