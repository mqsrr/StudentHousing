using StudentHousing.Contracts.Complaints.Responses;
using StudentHousingApp.Models;
using System.Runtime.CompilerServices;

namespace StudentHousingApp.Mappers;

internal static class ComplaintMapper
{
    public static Complaint ToComplaint(this ComplaintResponse response)
    {
        return new Complaint
        {
            Id = response.Id,
            Title = response.Title,
            Description = response.Description,
            CreatedAt = response.CreatedAt,
            State = (ComplaintState)response.State
        };
    }
}
