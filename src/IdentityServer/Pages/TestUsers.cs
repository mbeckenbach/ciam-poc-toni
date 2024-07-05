// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace IdentityServer;

public class CRMContact {
    public Guid Id { get; set; }
    public int IdentityId { get; set; }
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

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        { 
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "alice" // TODO: Should be a hash...
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "bob" // TODO: Should be a hash...
                }
            };
        }
    }
}