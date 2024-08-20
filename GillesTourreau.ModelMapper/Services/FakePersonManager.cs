//-----------------------------------------------------------------------
// <copyright file="FakePersonManager.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public class FakePersonManager : IPersonManager
    {
        private static readonly Person[] persons =
        [
            new Person(1, "John", "DOE"),
            new Person(2, "Jack", "SPARROW"),
            new Person(3, "Steve", "ROGERS"),
        ];

        public FakePersonManager()
        {
        }

        public Person GetByID(int id)
        {
            return persons.Single(p => p.Id == id);
        }

        public Person GetByName(string name)
        {
            return persons.Single(p => p.FirstName == name || p.LastName == name);
        }
    }
}
