﻿using System;
using Newtonsoft.Json;

namespace PetStoreAPI.Modals
{
	public class User
	{
        public long Id { get; set; }
        public string? Username { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Phone { get; set; }

        public int UserStatus { get; set; }
    }
}

