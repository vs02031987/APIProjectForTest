using APIProjectForTest;
using APIProjectForTest.DBContexts;
using APIProjectForTest.Repository;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder
           .Services
           .AddCors(options =>
           {
               options.AddDefaultPolicy(builder =>
               {
                   builder
                       .WithOrigins("https://studio.apollographql.com")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
               });
           });
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<IStudentRepository, StudentRepository>();
        builder.Services.
            AddDbContext<StudentContext>(x =>
            x.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));
        builder.Services
          .AddGraphQLServer()
          .AddQueryType<Query>()
          .AddMutationType<Mutation>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}

        //app.UseHttpsRedirection();

        //app.UseAuthorization();

        //app.MapControllers();
        app.UseCors();
        app.MapGraphQL();
        app.Run();
    }
}