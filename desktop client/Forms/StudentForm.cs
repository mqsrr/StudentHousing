using StudentHousing.Contracts.Complaints.Requests;
using StudentHousing.Contracts.HousingTasks.Requests;
using StudentHousing.Contracts.Parties.Requests;
using StudentHousingApp.Extensions;
using StudentHousingApp.Forms;
using StudentHousingApp.Helpers;
using StudentHousingApp.Models;
using StudentHousingApp.Services;

namespace Student_housing_project;

public partial class StudentForm : Form
{

    private readonly StudentService _studentService;
    private readonly PartyService _partyService;



    private Student _student;

    public StudentForm()
    {
        InitializeComponent();
        _studentService = new StudentService();
        _partyService = new PartyService();

        _studentService.OnComplaintCreated += OnComplaintCreated;
        _partyService.OnPartyCreated += OnPartyCreated;
        _partyService.OnStudentAddedToParty += OnStudentAddedToParty;
    }

    private void OnComplaintCreated(Complaint complaint)
    {
        complaintTitleTextBox.Clear();
        complaintDescriptionTextBox.Clear();
    }
    private void OnPartyCreated(Party party)
    {
        partyListBox.Items.Add(party);

        createPartyName.Clear();
        createPartyDescription.Clear();
        createPartyTime.Clear();
    }

    private void OnStudentAddedToParty(Party party, Student student)
    {
        _student.JoinedPartyIds.Add(party.Id);
        party.Members.Add(student);

        partyListBox.SelectedIndex = -1;
    }

    private async void StudentForm_Load(object sender, EventArgs e)
    {
        var student = await _studentService.GetStudentByUsernameAsync(StaticStorage.Username);
        var garbageScheduleList = await _studentService.GetAllGarbageDisposalScheduleAsync();
        var parties = await _partyService.GetAllPartiesAsync();

        if (student is null)
        {
            MessageBoxExtensions.ShowError("Unable to load information!");
            Close();
            return;
        }

        _student = student;

        partyListBox.Items.AddRange(parties.ToArray());
        housingTasksListBox.Items.AddRange(_student.HousingTasks.ToArray());
        garbageListBox.Items.AddRange(garbageScheduleList.ToArray());
    }

    private void housingTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedHousingTask = housingTasksListBox.SelectedItem as HousingTask;
        if (selectedHousingTask is null)
        {
            return;
        }
        new OverviewForm(selectedHousingTask).ShowDialog();
    }

    private void viewCurrentTasksButton_Click(object sender, EventArgs e)
    {
        PopulateHousingTaskListBox(task => task.State == HousingTaskState.Todo);
    }

    private void viewCompletedTasksButton_Click(object sender, EventArgs e)
    {
        PopulateHousingTaskListBox(task => task.State == HousingTaskState.Done);
    }

    private void viewAllTasksButton_Click(object sender, EventArgs e)
    {
        PopulateHousingTaskListBox();
    }

    private void PopulateHousingTaskListBox(Func<HousingTask, bool>? predicate = null)
    {
        var housingTasks = predicate is null
            ? _student.HousingTasks.ToArray()
            : _student.HousingTasks.Where(predicate).ToArray();

        housingTasksListBox.Items.Clear();
        housingTasksListBox.Items.AddRange(housingTasks);
    }

    private async void changeHousingTaskStateButton_ClickAsync(object sender, EventArgs e)
    {
        var selectedTask = housingTasksListBox.SelectedItem as HousingTask;
        if (selectedTask is null)
        {
            MessageBoxExtensions.ShowInformation("Please select the task to update!");
            return;
        }

        selectedTask.State = selectedTask.State == HousingTaskState.Todo ? HousingTaskState.Done : HousingTaskState.Todo;
        var isUpdated = await _studentService.UpdateHousingTaskState(_student.Id, selectedTask.Id, new UpdateHousingTaskRequest
        {
            State = (short)selectedTask.State
        });

        if (!isUpdated)
        {
            MessageBoxExtensions.ShowError("We have encountered an error during updating task's state");
            return;
        }
        housingTasksListBox.SelectedIndex = -1;
    }

    private async void fileComplaintButton_Click(object sender, EventArgs e)
    {
        if (!TryCreateComplaintRequest(complaintTitleTextBox.Text, complaintDescriptionTextBox.Text, out var request))
        {
            MessageBoxExtensions.ShowInformation("Please provide title and description for your complaint");
            return;
        }

        var isCreated = await _studentService.CreateComplaintAsync(request!);
        if (!isCreated)
        {
            MessageBoxExtensions.ShowError("Couldn't create complaint!");
            return;
        }

        MessageBoxExtensions.ShowInformation("Complaint has been created!");
    }

    private bool TryCreateComplaintRequest(string title, string description, out CreateComplaintRequest? request)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
        {
            request = null;
            return false;
        }

        request = new CreateComplaintRequest
        {
            Title = complaintTitleTextBox.Text,
            Description = complaintDescriptionTextBox.Text
        };

        return true;
    }

    private void partyListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedParty = partyListBox.SelectedItem as Party;
        if (selectedParty is null)
        {
            return;
        }

        bool isPartyJoined = _student.JoinedPartyIds.Contains(selectedParty.Id);
        if (isPartyJoined)
        {
            joinPartyButton.Enabled = false;
            openPartyButton.Enabled = true;
            return;
        }

        joinPartyButton.Enabled = true;
        openPartyButton.Enabled = false;
    }

    private void OpenPartyDetails_Action(object? sender, EventArgs e)
    {
        var selectedParty = partyListBox.SelectedItem as Party;
        if (selectedParty is null)
        {
            MessageBoxExtensions.ShowInformation("Please select party!");
            return;
        }

        var partyDetails = new PartyDetailsForm(selectedParty, _student);
        partyDetails.ShowDialog();

        partyListBox.SelectedIndex = -1;
    }

    private async void JoinParty_ActionAsync(object? sender, EventArgs e)
    {
        var selectedParty = partyListBox.SelectedItem as Party;
        if (selectedParty is null)
        {
            MessageBoxExtensions.ShowInformation("Please select party!");
            return;
        }

        var isAdded = await _partyService.AddStudentToPartyAsync(selectedParty, _student);
        if (!isAdded)
        {
            MessageBoxExtensions.ShowError("Couldn't join the party! Try again!");
            return;
        }
    }

    private async void createPartyButton_Click(object sender, EventArgs e)
    {
        var date = createPartyStartDate.Value.Date;

        if (!TimeSpan.TryParse(createPartyTime.Text, out var result)
            || !TryCreatePartyRequest(createPartyName.Text, createPartyDescription.Text, date.Add(result), out var request))
        {
            MessageBoxExtensions.ShowInformation("Please fill all data!");
            return;
        }

        bool isCreated = await _partyService.CreatePartyAsync(request!);
        if (!isCreated)
        {
            MessageBoxExtensions.ShowError("Party couldn't be created. Please Try Again!");
            return;
        }
    }

    private bool TryCreatePartyRequest(string partyName, string partyDescription, DateTime partyStateDate, out CreatePartyRequest? request)
    {
        if (string.IsNullOrEmpty(partyName) || string.IsNullOrEmpty(partyDescription))
        {
            request = null;
            return false;
        }

        request = new CreatePartyRequest
        {
            Name = partyName,
            Description = partyDescription,
            StartDate = partyStateDate
        };
        return true;
    }
}
