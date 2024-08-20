//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Gilles TOURREAU">
//     Copyright (c) Gilles TOURREAU. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace GillesTourreau.ModelMapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.AddScoped<IPersonManager, FakePersonManager>();
            builder.Services.AddSingleton<IPersonJsonMapper, PersonJsonMapper>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
