namespace StudentHousingApp.Helpers;

internal static class ApiEndpoints
{
    public const string BaseAddress = "http://localhost:5069";
    private const string ApiBase = "/api";

    internal sealed class Auth
    {
        public const string Login = $"{ApiBase}/login";

        public const string Register = $"{ApiBase}/register";

        public const string RegisterAdmin = $"{ApiBase}/admin/register";
    }

    internal sealed class Garbage
    {
        private const string Base = $"{ApiBase}/garbages";

        public const string GetAll = Base;

        public const string Create = Base;

        public const string Update = $"{Base}/{{id}}";

        public const string Delete = $"{Base}/{{id}}";
    }

    internal sealed class Party
    {
        private const string Base = $"{ApiBase}/parties";

        public const string GetAll = Base;

        public const string GetById = $"{Base}/{{id}}";

        public const string Create = Base;

        public const string AddStudentToParty = $"{Base}/{{id}}";

        public const string RemoveStudentFromParty = $"{Base}/{{id}}";
    }

    internal sealed class Students
    {
        private const string Base = $"{ApiBase}/students";

        public const string GetAll = Base;

        public const string GetById = $"{Base}/{{id}}";

        public const string GetByUsername = $"{Base}/{{username}}";
    }

    internal sealed class HousingTasks
    {
        private const string Base = $"{ApiBase}/students/{{studentId}}/housing-tasks";

        public const string Create = Base;

        public const string DeleteById = $"{Base}/{{id}}";

        public const string UpdateState = $"{Base}/{{id}}";
    }

    internal sealed class Complaints
    {
        private const string Base = $"{ApiBase}/complaints";

        public const string GetAll = Base;

        public const string Create = Base;

        public const string UpdateState = $"{Base}/{{id}}";
    }

    internal sealed class Rooms
    {
        private const string Base = $"{ApiBase}/rooms";

        public const string GetAll = Base;

        public const string GetAvailableRooms = $"{Base}/without-students";

        public const string Get = $"{Base}/{{id}}";

        public const string Create = Base;

        public const string AssignStudent = $"{Base}/{{id}}/students/{{studentId}}";
    }
}