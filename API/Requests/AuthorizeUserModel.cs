﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Responses;

namespace API.Requests
{
    public class AuthorizeUserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }


        public AuthorizeUserModel()
        {
            
        }


        public static explicit operator ResponseUserModel(AuthorizeUserModel model)
        {
            return new ResponseUserModel
            {
                Email = model.Email
            };
        }
    }
}