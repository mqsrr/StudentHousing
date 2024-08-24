using StudentHousing.Contracts.Complaints.Requests;
using StudentHousing.Contracts.HousingTasks.Requests;
using StudentHousingApp.Helpers;
using StudentHousingApp.Mappers;
using StudentHousingApp.Models;
using StudentHousingApp.WebClients;

namespace StudentHousingApp.Services;

internal sealed class StudentService
{
    private readonly IStudentApi _studentApi;
    private readonly IHousingTaskApi _housingTaskApi;
    private readonly IComplaintApi _complaintApi;
    private readonly IGarbageApi _garbageApi;

    public Action<Student, HousingTask>? OnHousingTaskCreated { get; set; }

    public Action<HousingTaskState>? OnHousingTaskStatusUpdated { get; set; }

    public Action<Complaint>? OnComplaintCreated { get; set; }


    public StudentService()
    {
        _studentApi = ApiFactory.CreateNewInstance<IStudentApi>();
        _housingTaskApi = ApiFactory.CreateNewInstance<IHousingTaskApi>();

        _complaintApi = ApiFactory.CreateNewInstance<IComplaintApi>();
        _garbageApi = ApiFactory.CreateNewInstance<IGarbageApi>();
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        var response = await _studentApi.GetAllAsync();
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<Student>();
        }

        var students = response.Content!.Select(student => student.ToStudent());
        return students;
    }    

    public async Task<Student?> GetStudentByIdAsync(Guid id)
    {
        var response = await _studentApi.GetByIdAsync(id);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var student = response.Content!.ToStudent();
        return student;
    } 

    public async Task<Student?> GetStudentByUsernameAsync(string username)
    {
        var response = await _studentApi.GetByUsernameAsync(username);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var student = response.Content!.ToStudent();
        return student;
    }
    
    public async Task<IEnumerable<Complaint>> GetAllComplaintsAsync()
    {
        var response = await _complaintApi.GetAllAsync();
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<Complaint>();
        }

        return response.Content!.Select(complaint => complaint.ToComplaint());
    }

    public async Task<bool> CreateHousingTask(Student student, CreateHousingTaskRequest request)
    {
        var response = await _housingTaskApi.CreateAsync(student.Id, request);
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        OnHousingTaskCreated?.Invoke(student, response.Content!.ToTask());
        return true;
    }
    public async Task<bool> UpdateHousingTaskState(Guid studentId, Guid id, UpdateHousingTaskRequest request)
    {
        var response = await _housingTaskApi.UpdateStateAsync(studentId, id, request);
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        OnHousingTaskStatusUpdated?.Invoke((HousingTaskState)request.State);
        return true;
    }

    public async Task<bool> CreateComplaintAsync(CreateComplaintRequest request)
    {
        var response = await _complaintApi.CreateAsync(request);
        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        OnComplaintCreated?.Invoke(response.Content!.ToComplaint());
        return true;
    }
    
    public async Task<IEnumerable<GarbageDisposal>> GetAllGarbageDisposalScheduleAsync()
    {
        var response = await _garbageApi.GetAllAsync();
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<GarbageDisposal>();
        }

        return response.Content!.OrderBy(garbage => garbage.DateOfDisposal);
    }    
  
}
