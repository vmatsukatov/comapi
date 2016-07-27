using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IAccount
    {
        string AccountKey { get; set; }
        string AccountLogin { get; set; }
        string AccountFullName { get; set; }
        string AcountAvatarURL { get; set; }
    }
}
