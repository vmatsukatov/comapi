﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public interface IProject
    {
        string id { get; set; }
        string key { get; set; }
        string name { get; set; }

    }
}
