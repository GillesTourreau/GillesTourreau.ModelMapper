//-----------------------------------------------------------------------
// <copyright file="PersonController.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("persons")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager manager;

        private readonly IPersonJsonMapper jsonMapper;

        public PersonController(IPersonManager manager, IPersonJsonMapper jsonMapper)
        {
            this.manager = manager;
            this.jsonMapper = jsonMapper;
        }

        [HttpGet("byId/{id}")]
        public PersonJson GetById(int id)
        {
            var person = this.manager.GetByID(id);
            var personJson = this.jsonMapper.ToJson(person);

            return personJson;
        }

        [HttpGet("byName/{name}")]
        public PersonJson GetByName(string name)
        {
            var person = this.manager.GetByName(name);
            var personJson = this.jsonMapper.ToJson(person);

            return personJson;
        }
    }
}
