//-----------------------------------------------------------------------
// <copyright file="PersonJsonMappingTest.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper.Tests
{
    using FluentAssertions;

    public class PersonJsonMappingTest
    {
        [Fact]
        public void ToJson()
        {
            // Arrange
            var person = new Person(1234, "John", "DOE");

            var mapper = new PersonJsonMapper();

            // Act
            var json = mapper.ToJson(person);

            // Assert
            json.FirstName.Should().Be("John");
            json.Id.Should().Be(1234);
            json.LastName.Should().Be("DOE");
        }
    }
}