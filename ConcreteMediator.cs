using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProj
{
    public class ConcreteMediator : IMediator
    {
        private readonly List<IColleague> _colleagues;
        public ConcreteMediator(params IColleague[] colleagues)
        {
            ArgumentNullException.ThrowIfNull(colleagues);
            _colleagues = new List<IColleague>(colleagues);
        }          
        public void Send(Message message)
        {
            foreach (var colleague in _colleagues)
            {
                if (colleague != message.Sender)
                {
                    colleague.ReceiveMessage(message);
                }
            }
        }
    }
}
