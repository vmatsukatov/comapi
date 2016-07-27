using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBotClient
{
    public interface IBotClient
    {
        IResponse SendRequest(IRequest request);
    }
}
