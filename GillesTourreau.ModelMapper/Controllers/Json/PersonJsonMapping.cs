//-----------------------------------------------------------------------
// <copyright file="PersonJsonMapper.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public class PersonJsonMapper : IPersonJsonMapper
    {
        public PersonJson ToJson(Person person)
        {
            return new PersonJson(person.Id, person.FirstName, person.LastName);
        }
    }
}