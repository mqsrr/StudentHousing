namespace StudentHousingApp.Extensions;

internal static class MessageBoxExtensions
{
    public static DialogResult ShowError(string message)
    {
        return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }   

    public static DialogResult ShowInformation(string message)
    {
        return MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
