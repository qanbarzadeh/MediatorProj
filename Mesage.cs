namespace MediatorProj
{
    public class Message
    {
        public IColleague Sender { get; private set; }
        public string messageContent { get; private set; }

        public Message(string messageContent, IColleague sender)
        {
            Sender = sender;
            this.messageContent = messageContent;

            Sender = sender ?? throw new ArgumentNullException(nameof(sender));
            this.messageContent = messageContent ?? throw new ArgumentNullException(nameof(messageContent));
        }

        



    }
}