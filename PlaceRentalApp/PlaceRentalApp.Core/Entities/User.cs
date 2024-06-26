﻿using System.Data;

namespace PlaceRentalApp.Core.Entities
{
    public abstract partial class BaseEntity
    {
        public class User : BaseEntity
        {
            protected User() { }

            public User(string fullName, string email, DateTime birtDate, string password, string role)
                : base()
            {
                FullName = fullName;
                Email = email;
                BirtDate = birtDate;
                Password = password;
                Role = role ?? "client";

                Books = [];
                Places = [];
            }

            public string FullName { get; private set; }
            public string Email { get; private set; }
            public DateTime BirtDate { get; private set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public List<PlaceBook> Books { get; private set; }
            public List<Place> Places { get; private set; }
        }
    }
}
