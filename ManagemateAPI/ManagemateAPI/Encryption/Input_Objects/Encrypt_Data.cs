﻿using ManagemateAPI.Management.M_Session.Input_Objects;

namespace ManagemateAPI.Encryption.Input_Objects
{
    public class Encrypt_Data
    {
        public Session_Data SessionData { get; set; }
        public string DataToEncrypt { get; set; }
    }
}