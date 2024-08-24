using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Repositories;

public interface IComplaintRepository
{
    Task<IEnumerable<Complaint>> GetAllComplaintsAsync();
    
    Task<bool> CreateComplainAsync(Complaint complaint);
}