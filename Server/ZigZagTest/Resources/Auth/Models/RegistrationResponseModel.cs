﻿namespace ZigZagTest.WebAPI.Resources.Auth.Models
{
    public class RegistrationResponseModel
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}
