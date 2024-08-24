using Microsoft.AspNetCore.Connections;
using StudentHousing.Contracts.Parties.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;
using StudentHousingApp.WebClients;

namespace StudentHousingApp.Services;

internal sealed class PartyService
{
    private readonly IPartyApi _partyApi;

    public Action<Party>? OnPartyCreated{ get; set; }

    public Action<Party, Student>? OnStudentAddedToParty { get; set; }

    public PartyService()
    {
        _partyApi = ApiFactory.CreateNewInstance<IPartyApi>();
    }

    public async Task<IEnumerable<Party>> GetAllPartiesAsync()
    {
        var partyResponse = await _partyApi.GetAllAsync();
        if (!partyResponse.IsSuccessStatusCode)
        {
            return Enumerable.Empty<Party>();
        }

        return partyResponse.Content!;
    }    

    public async Task<bool> CreatePartyAsync(CreatePartyRequest request)
    {
        var response = await _partyApi.CreateAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        OnPartyCreated?.Invoke(response.Content!);
        return true; ;
    }

    public async Task<bool> AddStudentToPartyAsync(Party party, Student student)
    {
        var response = await _partyApi.AddStudentToPartyAsync(party.Id, student.Id);
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        OnStudentAddedToParty?.Invoke(party, student);
        return true;
    }
}
