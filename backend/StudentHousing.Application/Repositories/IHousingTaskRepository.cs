using StudentHousing.Domain.Models;

namespace StudentHousing.Application.Repositories;

public interface IHousingTaskRepository
{
    Task<bool> CreateHousingTaskAsync(HousingTask housingTask, Guid studentId);

    Task<bool> DeleteHousingTaskByIdAsync(Guid id);

    Task<bool> UpdateTaskStateAsync(Guid id, HousingTaskState taskState);
}