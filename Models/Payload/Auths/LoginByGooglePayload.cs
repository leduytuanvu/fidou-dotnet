﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoiceAPI.Models.Payload.Auths
{
    public class LoginByGooglePayload
    {
        public string AccessToken { get; set; }
        public string GoogleId { get; set; }
    }
}