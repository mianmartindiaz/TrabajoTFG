﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_lavera.Service
{
    public interface IEmailService
    {
        void Send(string email);
    }
}