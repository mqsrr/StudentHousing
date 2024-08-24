namespace StudentHousing.API.Helpers;

internal static class ApiEndpoints
{
    private const string ApiBase = "/api";
    
    internal sealed class Auth
    {
        public const string Login = $"{ApiBase}/login";
        
        public const string Register = $"{ApiBase}/register";
        
        public const string RegisterAdmin = $"{ApiBase}/admin/register";
    }
    
    internal sealed class Students
    {
        private const string Base = $"{ApiBase}/students";
        
        public const string GetById = $"{Base}/{{id:guid}}";
        
        public const string GetByUsername = $"{Base}/{{username}}";
    }
    
    internal sealed class HousingTasks
    {
        private const string Base = $"{ApiBase}/students/{{studentId:guid}}/housing-tasks";
        
        public const string Create = Base;
        
        public const string DeleteById = $"{Base}/{{id:guid}}";
        
        public const string UpdateState = $"{Base}/{{id:guid}}";
    }
    
    internal sealed class Complaints
    {
        private const string Base = $"{ApiBase}/complaints";
        
        public const string GetAll = Base;

        public const string Create = Base;
    }
    
    internal sealed class Rooms
    {
        private const string Base = $"{ApiBase}/rooms";
        
        public const string GetAll = Base;
        
        public const string GetAvailableRooms = $"{Base}/without-students";
        
        public const string Get = $"{Base}/{{id:guid}}";
        
        public const string Create = Base;
        
        public const string AssignStudent = $"{Base}/{{id:guid}}/students/{{studentId:guid}}";
    }
}