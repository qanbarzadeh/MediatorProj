using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProj
{
    public interface IColleague
    {
        string Name { get; }
        void ReceiveMessage(Message message);
    }
}
