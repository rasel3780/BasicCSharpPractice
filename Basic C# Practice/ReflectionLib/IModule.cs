﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public interface IModule
    {
        Guid Id { get; set; }
        string Name { get; set; }

        void Start();
    }
}
