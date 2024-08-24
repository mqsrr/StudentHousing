namespace StudentHousing.Infrastructure.Helpers;

internal static class StoredProcedures
{
    internal sealed class Auth
    {
        public const string Login = "spGetIdentityByUsername";
        
        public const string Register = "spRegister";
        
        public const string IsEmailExists = "spGetIdentityByEmail";
    }
    
    internal sealed class Students
    {
        public const string GetById = "spGetStudentById";
        
        public const string GetByUsername = "spGetStudentByUsername";
        
        public const string Create = "spCreateStudent";
    }
    
    internal sealed class HousingTasks
    {
        public const string Create = "spCreateHousingTask";
        
        public const string DeleteById = "spDeleteHousingTaskById";
        
        public const string UpdateState = "spUpdateHousingTaskState";
    }
    
    internal sealed class Complaints
    {
        public const string Create = "spCreateComplaint";
        
        public const string GetAll = "spGetAllComplaints";
    }
    
    internal sealed class Rooms
    {
        public const string GetAll = "spGetAllRooms";
        
        public const string GetAvailableRooms = "spGetAvailableRooms";
        
        public const string GetById = "spGetRoomById";
        
        public const string Create = "spCreateRoom";
        
        public const string AssignStudent = "spAssignStudentToTheRoom";
    }
}