﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IClient
    {
        IEnumerable<IProject> GetAllProjects();
    }
}
