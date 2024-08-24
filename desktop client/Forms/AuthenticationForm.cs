using Refit;
using StudentHousing.Contracts.Auth.Requests;
using StudentHousingApp.Extensions;
using StudentHousingApp.Helpers;
using StudentHousingApp.Mappers;
using StudentHousingApp.Models;
using StudentHousingApp.WebClients;

namespace Student_housing_project;


public partial class AuthenticationForm : Form
{
    private readonly IAuthenticationApi _authenticationApi;

    public AuthenticationForm()
    {
        InitializeComponent();

        _authenticationApi = RestService.For<IAuthenticationApi>(ApiEndpoints.BaseAddress, new RefitSettings(new NewtonsoftJsonContentSerializer()));
    }

    private async void AuthenticationForm_Load(object sender, EventArgs e)
    {
        var roomsApi = RestService.For<IRoomApi>(ApiEndpoints.BaseAddress, new RefitSettings(new NewtonsoftJsonContentSerializer()));
        var response = await roomsApi.GetAvailableAsync();

        regAvailableRoomsComboBox.Items.AddRange(response.Content!.Select(response => response.ToRoom()).ToArray());
        regAvailableRoomsComboBox.DisplayMember = "RoomNumber";
    }


    private async void loginBtn_ClickAsync(object sender, EventArgs e)
    {
        var credentials = GetCredentialsFromTabPage(loginTabPage);
        if (!TryCreateLoginRequest(credentials, out var request))
        {
            MessageBoxExtensions.ShowError("Please provide all required fields.");
            return;
        }

        var response = await _authenticationApi.LoginAsync(request!);
        if (!response.IsSuccessStatusCode)
        {
            MessageBoxExtensions.ShowError("Username or password is incorrect");
            return;
        }

        var identity = response.Content!;
        StaticStorage.JwtToken = identity.Token;
        StaticStorage.Username = request.Username;

        OpenForm(identity!.Role == Role.Student ? new StudentForm() : new AdminForm());
    }


    private async void registerBtn_Click(object sender, EventArgs e)
    {
        var credentials = GetCredentialsFromTabPage(registerTabPage);
        if (!ArePasswordsMatching(credentials, out string errorMessage))
        {
            MessageBoxExtensions.ShowError(errorMessage);
            return;
        }

        var selectedRoom = regAvailableRoomsComboBox.SelectedItem as Room;
        if (!TryCreateRegisterRequest(credentials, selectedRoom, out var request))
        {
            MessageBoxExtensions.ShowError("Please provide all required fields.");
            return;
        }

        var response = await _authenticationApi.RegisterAsync(request!);
        if (!response.IsSuccessStatusCode)
        {
            MessageBoxExtensions.ShowError("Registration failed. Please check your credentials and try again.");
            return;
        }

        StaticStorage.JwtToken = response.Content!.Token;
        StaticStorage.Username = request.Username;

        OpenForm(new StudentForm());
    }

    private static bool TryCreateLoginRequest(Dictionary<string, string> credentials, out LoginRequest? request)
    {
        if (credentials.Values.Any(string.IsNullOrEmpty))
        {
            request = null;
            return false;
        }

        request = new LoginRequest
        {
            Username = credentials["Username"],
            Password = credentials["Password"],
        };

        return true;
    }

    private bool TryCreateRegisterRequest(Dictionary<string, string> credentials, Room? selectedRoom, out RegisterRequest? request)
    {
        if (credentials.Values.Any(string.IsNullOrEmpty) || selectedRoom is null)
        {
            request = null;
            return false;
        }

        request = new RegisterRequest
        {
            Email = credentials["Email"],
            Username = credentials["Username"],
            Password = credentials["Password"],
            FullName = credentials["FullName"],
            Birthdate = DateOnly.FromDateTime(birthdateDateTimePicker.Value),
            Room = selectedRoom.ToRegisterRequest()
        };
        return true;
    }

    private void OpenForm(Form form)
    {
        form.FormClosed += (_, _) => Close();
        form.Show();

        Hide();
    }

    private bool ArePasswordsMatching(Dictionary<string, string> credentials, out string errorMessage)
    {
        if (credentials["Password"] != credentials["ConfirmPassword"])
        {
            errorMessage = "Passwords do not match.";
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }

    private Dictionary<string, string> GetCredentialsFromTabPage(TabPage tabPage)
    {
        return tabPage.Controls
                .OfType<TextBox>()
                .ToDictionary(textBox => (string)textBox.Tag!, textBox => textBox.Text);
    }
}
