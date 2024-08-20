//-----------------------------------------------------------------------
// <copyright file="IPersonJsonMapper.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public interface IPersonJsonMapper
    {
        PersonJson ToJson(Person person);
    }
}
