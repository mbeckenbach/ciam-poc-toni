// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using System.Security.Claims;
using System.Text.Json;
using System.Reflection.Metadata.Ecma335;

namespace CRM;

public class Contact {
    public Guid Id { get; set; }
    public int IdentityId { get; set; }
    public string ERPAccountNumber { get; set; }
    public string DisplayName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string WebSite { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }
}

public static class DemoContacts {
    public static List<Contact> Contacts {
        get {
            return new List<Contact> {
                new Contact{
                    Id = Guid.NewGuid(),
                    IdentityId = 1,
                    ERPAccountNumber = "12344455",
                    DisplayName = "Alice Smith",
                    FirstName = "Alice",
                    LastName = "Smith",
                    Email = "AliceSmith@email.com",
                    Street = "One Hacker Way",
                    City = "Heidelberg",
                    Zip = "69118",
                    Country = "Germany"
                },
                new Contact{
                    Id = Guid.NewGuid(),
                    IdentityId = 2,
                    ERPAccountNumber = "12344455",
                    DisplayName = "Bob Smith",
                    FirstName = "Bob",
                    LastName = "Smith",
                    Email = "BobSmith@email.com",
                    Street = "One Hacker Way",
                    City = "Heidelberg",
                    Zip = "69118",
                    Country = "Germany"
                }
            };
        }
    }
}