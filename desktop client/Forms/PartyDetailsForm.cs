using Chat;
using StudentHousingApp.Extensions;
using StudentHousingApp.Models;
using StudentHousingApp.Services;
using StudentHousingApp.WebClients;

namespace StudentHousingApp.Forms;

internal partial class PartyDetailsForm : Form
{
    private readonly ChatChannel _chatService;
    private readonly HubConnectionService _hubConnectionService;

    private readonly Party _party;
    private readonly Student _student;

    public PartyDetailsForm(Party party, Student student)
    {
        InitializeComponent();

        _chatService = new ChatChannel();
        _hubConnectionService = new HubConnectionService(student);

        _party = party;
        _student = student;

        _party.Messages = _party.Messages.Select(message =>
        {
            var messageAuthor = _party.Members.First(student => student.Id == message.StudentId);
            message.Username = messageAuthor.Username;

            return message;
        }).DistinctBy(message => message.Id).ToList();

        membersListBox.Items.AddRange(_party.Members.ToArray());
        membersListBox.DisplayMember = "UserName";

        partyStartTimeLabel.Text = _party.StartDate.ToString("g");
        PopulateChatListBox();
    }

    private async void sendButton_Click(object sender, EventArgs e)
    {
        string messageText = messageTextBox.Text;
        if (string.IsNullOrEmpty(messageText))
        {
            MessageBoxExtensions.ShowInformation("Please enter your message!");
            return;
        }

        messageTextBox.Clear();
        await _chatService.SendMessageAsync(new ChatMessage
        {
            Id = Guid.NewGuid().ToString(),
            PartyId = _party.Id.ToString(),
            StudentId = _student.Id.ToString(),
            Message = messageText,
            SentAt = DateTime.Now.ToBinary()
        }).ConfigureAwait(false);
    }

    private async void PartyDetailsForm_Load(object sender, EventArgs e)
    {
        var currentContext = SynchronizationContext.Current;

        await _hubConnectionService.StartConnectionAsync();
        await _hubConnectionService.JoinPartyAsync(_party.Id);

        _hubConnectionService.OnMessageSent(message =>
        {
            currentContext!.Send(_ =>
            {
                if (message.PartyId != _party.Id)
                {
                    return;
                }

                var messageAuthor = _party.Members.First(student => student.Id == message.StudentId);
                message.Username = messageAuthor.Username;

                if (!chatListBox.Items.Contains(message))
                {
                    chatListBox.Items.Add(message);
                }

                if (!_party.Messages.Contains(message))
                {
                    _party.Messages.Add(message);
                }
            }, null);

        });
    }

    private async void PartyDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        await _hubConnectionService.DisposeAsync().ConfigureAwait(false);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        chatListBox.Items.Clear();

        var allMessages = _party.Messages;
        string filterText = textBox1.Text;

        if (string.IsNullOrEmpty(filterText))
        {
            PopulateChatListBox();
            return;
        }

        Func<Models.Message, bool> predicate = DateTime.TryParse(filterText, out var result)
            ? message => message.SentAt.Date == result.Date
            : message => message.Username!.Contains(filterText);

        PopulateChatListBox(predicate);
    }

    private void PopulateChatListBox(Func<Models.Message, bool>? predicate = null)
    {
        var messages = predicate is null
            ? _party.Messages.OrderBy(message => message.SentAt).ToArray()
            : _party.Messages.OrderBy(message => message.SentAt).Where(predicate).ToArray();

        chatListBox.Items.Clear();
        chatListBox.Items.AddRange(messages);
    }
}
