//-----------------------------------------------------------------------
// <copyright file="PersonJson.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    using System.Text.Json.Serialization;

public class PersonJson
{
    public PersonJson(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    [JsonPropertyName("id")]
    public int Id { get; }

    [JsonPropertyName("firstName")]
    public string FirstName { get; }

    [JsonPropertyName("lastName")]
    public string LastName { get; }
}
}
