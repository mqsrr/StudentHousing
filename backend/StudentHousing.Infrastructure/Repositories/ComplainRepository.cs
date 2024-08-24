using StudentHousing.Application.Persistence;
using StudentHousing.Application.Repositories;
using StudentHousing.Domain.Models;
using StudentHousing.Infrastructure.Helpers;

namespace StudentHousing.Infrastructure.Repositories;

internal sealed class ComplainRepository(ISqlDataAccess dataAccess) : IComplaintRepository
{
    private readonly ISqlDataAccess _dataAccess = dataAccess;

    public Task<IEnumerable<Complaint>> GetAllComplaintsAsync()
    {
        return _dataAccess.ExecuteQueryAsync<Complaint, dynamic>(StoredProcedures.Complaints.GetAll, new {});
    }

    public Task<bool> CreateComplainAsync(Complaint complaint)
    {
        return _dataAccess.ExecuteScalarAsync(StoredProcedures.Complaints.Create, complaint);
    }
}