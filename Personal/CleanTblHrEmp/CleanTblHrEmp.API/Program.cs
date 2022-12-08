using CleanTblHrEmp.API;
using CleanTblHrEmp.Application.Commands.HrEmp.GetHrEmp;
using CleanTblHrEmp.Domain.Models;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.
builder.Services.RegisterMediatR();
builder.Services.RegisterInfrastructure();
builder.Services.RegisterServices();
builder.Services.RegisterTasks(builder);


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddMediatR(typeof(GetHrEmpCommand));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbInnoxContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
