using StudentHousing.Contracts.Complaints.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Mappers;
using StudentHousingApp.Models;
using StudentHousingApp.WebClients;

namespace StudentHousingApp.Services;

internal sealed class ComplaintService
{
    private readonly IComplaintApi _complaintApi;

    public ComplaintService()
    {
        _complaintApi = ApiFactory.CreateNewInstance<IComplaintApi>();
    }


    public async Task<IEnumerable<Complaint>> GetAllAsync()
    {
        var response = await _complaintApi.GetAllAsync();
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<Complaint>();
        }

        var complaints = response.Content!.Select(complaint => complaint.ToComplaint());
        return complaints;
    }

    public async Task<bool> CreateAsync(CreateComplaintRequest request)
    {
        var response = await _complaintApi.CreateAsync(request);
        return response.IsSuccessStatusCode;
    }
}
