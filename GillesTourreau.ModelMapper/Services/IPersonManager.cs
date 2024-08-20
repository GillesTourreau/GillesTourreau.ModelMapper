//-----------------------------------------------------------------------
// <copyright file="IPersonManager.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public interface IPersonManager
    {
        Person GetByID(int id);

        Person GetByName(string name);
    }
}
