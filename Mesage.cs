namespace MediatorProj
{
    public class Message
    {
        public IColleague Sender { get; private set; }
        public string MessageContent { get; private set; }

        public Message(string messageContent, IColleague sender)
        {
            Sender = sender;
            MessageContent = messageContent;

            Sender = sender ?? throw new ArgumentNullException(nameof(sender));
            MessageContent = messageContent ?? throw new ArgumentNullException(nameof(messageContent));
        }

        



    }
}