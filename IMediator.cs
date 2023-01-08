using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProj
{
    public interface IMediator
    {
        void Send(Message message); // Send message to all participants

    }

    
}
