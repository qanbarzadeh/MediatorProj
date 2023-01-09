using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProj
{
    public class ConcreteColleague : IColleague
    {
        public string Name { get; }
        private readonly IMessageWriter<Message> _messageWriter;

        public ConcreteColleague(string name, IMessageWriter<Message> messageWriter)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _messageWriter = messageWriter ?? throw new ArgumentNullException(nameof(messageWriter));
        }                    

        public void ReceiveMessage(Message message)
        {
            _messageWriter.WriteMessage(message);
        }
    }        
    
}
