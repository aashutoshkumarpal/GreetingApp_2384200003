﻿using ModelLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IGreetingBL
    {
        string GetGreet();

        string GetGreetingMessage(UsernameRequestModel request);
    }
}
