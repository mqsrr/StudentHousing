using StudentHousing.Contracts.HousingTasks.Requests;
using StudentHousing.Contracts.Rooms.Requests;
using StudentHousingApp.Extensions;
using StudentHousingApp.Forms;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;
using StudentHousingApp.Services;
using StudentHousingApp.WebClients;

namespace Student_housing_project;

public partial class AdminForm : Form
{

    private readonly StudentService _studentService;
    private readonly RoomService _roomService;
    private readonly IComplaintApi _complaintApi;

    private List<Student> _students = null!;
    private List<Complaint> _complaints = null!;
    private List<Room> _rooms = null!;

    public AdminForm()
    {
        InitializeComponent();

        _studentService = new StudentService();
        _roomService = new RoomService();
        _complaintApi = ApiFactory.CreateNewInstance<IComplaintApi>();

        _studentService.OnHousingTaskCreated += OnHousingTaskCreatedAsync;
        _roomService.OnRoomCreated += OnRoomCreated;
    }

    private async void OnHousingTaskCreatedAsync(Student studentToUpdate, HousingTask housingTask)
    {
        var updatedStudent = await _studentService.GetStudentByIdAsync(studentToUpdate.Id);
        int indexOfStudent = _students.FindIndex(student => student.Id == studentToUpdate.Id);

        if (indexOfStudent >= 0)
        {
            _students[indexOfStudent] = updatedStudent!;
        }

        var roomsToPresent = _students.Select(student => student.Room)
             .Concat(_rooms)
             .GroupBy(room => room.Id)
             .Select(groupedRoom => groupedRoom.First());

        roomsListBox.Items.Clear();
        roomsListBox.Items.AddRange(roomsToPresent.ToArray());

        studentsComboBox.Items.Remove(studentToUpdate);
        studentsComboBox.Items.Add(updatedStudent!);
        studentsComboBox.SelectedIndex = -1;

        taskOverviewStudentsComboBox.Items.Remove(studentToUpdate);
        taskOverviewStudentsComboBox.Items.Add(updatedStudent);
        taskOverviewStudentsComboBox.SelectedIndex = -1;

        createTaskTitleTextBox.Clear();
        createTaskDescriptionTextBox.Clear();

        PopulateHousingTaskListBox();
    }

    private void OnRoomCreated(Room room)
    {
        roomFloorUpDown.Value = 0;
        roomNumberUpDown.Value = 0;

        roomsListBox.Items.Add(room);
    }

    private async void AdminForm_Load(object sender, EventArgs e)
    {
        await LoadDataAsync();
        PopulateUIElements();
    }

    private void PopulateHousingTaskListBox()
    {
        housingTaskListBox.Items.Clear();
        housingTaskListBox.Items.AddRange(_students.SelectMany(student => student.HousingTasks).ToArray());

        taskOverviewStudentsComboBox.SelectedIndex = -1;
    }

    private async Task LoadDataAsync()
    {
        var getAllComplaintsTask = _studentService.GetAllComplaintsAsync();
        var getAllStudentsTask = _studentService.GetAllStudents();
        var getAllRoomsTask = _roomService.GetAllAsync();

        await Task.WhenAll(getAllComplaintsTask, getAllStudentsTask, getAllRoomsTask);

        _complaints = getAllComplaintsTask.Result.ToList();
        _students = getAllStudentsTask.Result.ToList();
        _rooms = getAllRoomsTask.Result.ToList();
    }

    private void PopulateUIElements()
    {
        var roomsToPresent = _students.Select(student => student.Room)
            .Concat(_rooms)
            .GroupBy(room => room.Id)
            .Select(groupedRoom => groupedRoom.First());

        roomsListBox.Items.AddRange(roomsToPresent.ToArray());

        complaintsListBox.Items.AddRange(_complaints.Where(complaint => complaint.State == ComplaintState.Todo).ToArray());
        complaintsListBox.DisplayMember = "Title";

        doneComplaintsListBox.Items.AddRange(_complaints.Where(complaint => complaint.State == ComplaintState.Done).ToArray());
        doneComplaintsListBox.DisplayMember = "Title";

        housingTaskListBox.Items.AddRange(_students.SelectMany(student => student.HousingTasks).ToArray());

        studentsComboBox.Items.AddRange(_students.ToArray());
        studentsComboBox.DisplayMember = "FullName";

        taskOverviewStudentsComboBox.Items.AddRange(_students.ToArray());
        taskOverviewStudentsComboBox.DisplayMember = "FullName";
    }

    private async void createNewRoomButton_ClickAsync(object sender, EventArgs e)
    {
        var request = new CreateRoomRequest
        {
            Floor = (int)roomFloorUpDown.Value,
            RoomNumber = (int)roomNumberUpDown.Value
        };

        if (RoomExists(request))
        {
            MessageBoxExtensions.ShowInformation("Provided room has already been created");
            return;
        }

        var response = await _roomService.CreateAsync(request);
        if (response is null)
        {
            MessageBoxExtensions.ShowError("Couldn't create room with given information. Please try again!");
            return;
        }
    }

    private bool RoomExists(CreateRoomRequest request)
    {
        return _students.Select(student => student.Room)
            .Any(room => room.RoomNumber == request.RoomNumber && room.Floor == request.Floor);
    }

    private async void createNewHousingTaskButton_Click(object sender, EventArgs e)
    {
        string taskTitle = createTaskTitleTextBox.Text;
        string taskDescription = createTaskDescriptionTextBox.Text;
        var selectedStudent = studentsComboBox.SelectedItem as Student;
        var dueDate = dueTaskDate.Value;

        if (!TryCreateHousingTaskRequest(taskTitle, taskDescription, dueDate, out var request) || selectedStudent is null)
        {
            MessageBoxExtensions.ShowError("Please input all values and select the student!");
            return;
        }

        bool isCreated = await _studentService.CreateHousingTask(selectedStudent, request!);
        if (!isCreated)
        {
            MessageBoxExtensions.ShowError("Unexpected Error!");
            return;
        }
    }

    private bool TryCreateHousingTaskRequest(string title, string description, DateTime dueDate, out CreateHousingTaskRequest? request)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || dueDate <= DateTime.UtcNow)
        {
            request = null;
            return false;
        }

        request = new CreateHousingTaskRequest
        {
            Title = title,
            Description = description,
            DueDate = dueDate
        };
        return true;
    }

    private void listAllHousingTasksButton_Click(object sender, EventArgs e)
    {
        PopulateHousingTaskListBox();
    }

    private void openComplaintButton_Click(object sender, EventArgs e)
    {
        var selectedComplaint = complaintsListBox.SelectedItem as Complaint;
        var selectedDoneComplaint = doneComplaintsListBox.SelectedItem as Complaint;

        OpenComplaintOverview(selectedComplaint);
        OpenComplaintOverview(selectedDoneComplaint);
    }

    private void OpenComplaintOverview(Complaint? complaint)
    {
        if (complaint is null)
        {
            return;
        }

        new OverviewForm(complaint).ShowDialog();
    }

    private void housingTaskListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedHousingTask = housingTaskListBox.SelectedItem as HousingTask;
        if (selectedHousingTask is null)
        {
            return;
        }

        new OverviewForm(selectedHousingTask).ShowDialog();
        housingTaskListBox.SelectedIndex = -1;
    }

    private async void changeComplaintStateButton_Click(object sender, EventArgs e)
    {
        if (!TryGetSelectedComplaint(out var selectedComplaint))
        {
            MessageBoxExtensions.ShowInformation("Please select complaint");
            return;
        }

        selectedComplaint!.State = selectedComplaint.State == ComplaintState.Todo
            ? ComplaintState.Done
            : ComplaintState.Todo;

        var response = await _complaintApi.UpdateStateAsync(selectedComplaint.Id, selectedComplaint.State);
        if (!response.IsSuccessStatusCode)
        {
            MessageBoxExtensions.ShowError("Selected Complaint couldn't be updated!");
            return;
        }

        var updatedComplaint = _complaints.First(complaint => complaint.Id == selectedComplaint.Id);

        _complaints.Remove(updatedComplaint);
        _complaints.Add(updatedComplaint);

        if (selectedComplaint.State is ComplaintState.Done)
        {
            complaintsListBox.Items.Remove(selectedComplaint);
            doneComplaintsListBox.Items.Add(selectedComplaint);

            return;
        }

        doneComplaintsListBox.Items.Remove(selectedComplaint);
        complaintsListBox.Items.Add(selectedComplaint);
    }

    private bool TryGetSelectedComplaint(out Complaint? complaint)
    {
        var selectedComplaint = complaintsListBox.SelectedItem as Complaint;
        var selectedDoneComplaine = doneComplaintsListBox.SelectedItem as Complaint;

        if (selectedComplaint is null && selectedDoneComplaine is null)
        {
            complaint = null;
            return false;
        }

        complaint = selectedComplaint is not null
            ? selectedComplaint
            : selectedDoneComplaine;

        return true;
    }

    private void taskOverviewStudentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedStudent = taskOverviewStudentsComboBox.SelectedItem as Student;
        if (selectedStudent is null)
        {
            return;
        }

        housingTaskListBox.Items.Clear();
        housingTaskListBox.Items.AddRange(selectedStudent.HousingTasks.ToArray());
    }
}
