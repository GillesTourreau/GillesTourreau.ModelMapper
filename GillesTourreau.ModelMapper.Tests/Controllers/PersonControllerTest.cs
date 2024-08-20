//-----------------------------------------------------------------------
// <copyright file="PersonControllerTest.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper.Tests
{
    using FluentAssertions;
    using Moq;

    public class PersonControllerTest
    {
        [Fact]
        public void GetById()
        {
            // Arrange
            var person = new Person(default, default, default);
            var personJson = new PersonJson(default, default, default);

            var manager = new Mock<IPersonManager>(MockBehavior.Strict);
            manager.Setup(m => m.GetByID(1234))
                .Returns(person);

            var mapper = new Mock<IPersonJsonMapper>(MockBehavior.Strict);
            mapper.Setup(m => m.ToJson(person))
                .Returns(personJson);

            var controller = new PersonController(manager.Object, mapper.Object);

            // Act
            var json = controller.GetById(1234);

            // Assert
            json.Should().BeSameAs(personJson);

            manager.VerifyAll();
            mapper.VerifyAll();
        }

        [Fact]
        public void GetByName()
        {
            var person = new Person(default, default, default);
            var personJson = new PersonJson(default, default, default);

            var manager = new Mock<IPersonManager>(MockBehavior.Strict);
            manager.Setup(m => m.GetByName("Someone"))
                .Returns(person);

            var mapper = new Mock<IPersonJsonMapper>(MockBehavior.Strict);
            mapper.Setup(m => m.ToJson(person))
                .Returns(personJson);

            var controller = new PersonController(manager.Object, mapper.Object);

            var json = controller.GetByName("Someone");

            json.Should().BeSameAs(personJson);

            manager.VerifyAll();
            mapper.VerifyAll();
        }
    }
}