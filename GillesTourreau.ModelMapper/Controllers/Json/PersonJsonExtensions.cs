//-----------------------------------------------------------------------
// <copyright file="PersonJsonExtensions.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public static class PersonJsonExtensions
    {
        public static PersonJson ToJson(this Person person)
        {
            return new PersonJson(person.Id, person.FirstName, person.LastName);
        }
    }
}
