using StudentHousingApp.Models;

namespace StudentHousingApp.Forms;

internal partial class ListAllHousingTasksForm : Form
{
    public ListAllHousingTasksForm(IEnumerable<HousingTask> housingTasks)
    {
        InitializeComponent();

        housingTasksListBox.Items.AddRange(housingTasks.ToArray());
    }

    private void housingTasksListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedHousingTask = housingTasksListBox.SelectedItem as HousingTask;

        housingTaskTitleTextBox.Text = selectedHousingTask!.Title;
        housingTaskDescriptionTextBox.Text = selectedHousingTask.Description;
        taskStateLabel.Text = selectedHousingTask.State.ToString();
    }
}
