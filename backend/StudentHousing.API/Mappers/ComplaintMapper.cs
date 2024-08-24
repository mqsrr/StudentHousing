using StudentHousing.Contracts.Complaints.Requests;
using StudentHousing.Contracts.Complaints.Responses;
using StudentHousing.Domain.Models;

namespace StudentHousing.API.Mappers;

internal static class ComplaintMapper
{
    internal static Complaint ToComplaint(this CreateComplaintRequest request)
    {
        return new Complaint
        {
            Id = request.Id,
            Title = request.Title,
            Description = request.Description,
            CreatedAt = DateTime.UtcNow
        };
    }
    
    internal static ComplaintResponse ToResponse(this Complaint complaint)
    {
        return new ComplaintResponse
        {
            Id = complaint.Id,
            Title = complaint.Title,
            Description = complaint.Description,
            CreatedAt = complaint.CreatedAt
        };
    }
}