using StudentHousingApp.Models;

namespace StudentHousingApp.Forms;

internal partial class OverviewForm : Form
{
    public OverviewForm(Complaint complaint)
    {
        InitializeComponent();

        titleTextBox.Text = complaint.Title;
        descriptionTextBox.Text = complaint.Description;
        stateLabel.Text = complaint.State.ToString();
    }

    public OverviewForm(HousingTask housingTask)
    {
        InitializeComponent();

        titleTextBox.Text = housingTask.Title;
        descriptionTextBox.Text = housingTask.Description;
        stateLabel.Text = housingTask.State.ToString();
    }
   
}
