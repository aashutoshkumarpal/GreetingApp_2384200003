﻿using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        bool RegisterUser(UserDTO userDTO);

        string LogIn(LoginDTO loginDTO);

        string ForgetPassword(ForgetPasswordDTO forgetPasswordDTO);

        bool ResetPassword(String Email, string Password);
    }
}
