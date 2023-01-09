namespace MediatorProj
{
    public class Message
    {
        public IColleague sender { get; private set; }
        public string messageContent { get; private set; }

        public Message(string messageContent, IColleague sender)
        {
            this.sender = sender;
            this.messageContent = messageContent;

            this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
            this.messageContent = messageContent ?? throw new ArgumentNullException(nameof(messageContent));
        }

        



    }
}