namespace TestWebApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string MessageContent { get; set; }
        public Message()
        {
            Date = DateTime.Now;
        }
    }
}
