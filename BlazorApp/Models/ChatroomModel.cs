using Chat.Entities;

namespace Chat.Models;

public class ChatroomModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public IEnumerable<UserModel> Users { get; set; }
    public IEnumerable<ChatMessageModel> Messages { get; set; }
}