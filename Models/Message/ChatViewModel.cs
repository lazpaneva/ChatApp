namespace ChatApp.Models.Message
{
    public class ChatViewModel
    {
        public MessageViewModel? CurrentMessage { get; set; } 
        
        public ICollection<MessageViewModel>? Messages { get; set; }
    }
}
