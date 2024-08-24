using Serilog;
using StudentHousing.API.Extensions;
using StudentHousing.Application.Persistence;
using StudentHousing.Application.Repositories;
using StudentHousing.Application.Services;
using StudentHousing.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJwtBearer(builder);
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddControllers();
builder.Services.AddApplicationService<IAuthenticationService>();
builder.Services.AddApplicationService<ITokenWriter>();

builder.Services.AddApplicationService<IStudentRepository>();
builder.Services.AddApplicationService<IRoomRepository>();

builder.Services.AddApplicationService<IHousingTaskRepository>();
builder.Services.AddApplicationService<IComplaintRepository>();

builder.Services.AddApplicationService<ISqlDataAccess>();

builder.Services.AddOptionsWithValidateOnStart<JwtSettings>()
    .Bind(builder.Configuration.GetRequiredSection(JwtSettings.SectionName));

var app = builder.Build();

app.UseSerilogRequestLogging();
app.MapControllers();

app.UseAuthorization();
app.UseAuthentication();

app.Run();