using CommandsService.Data;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(opt =>
        opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<ICommandRepo, CommandRepo>();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}
app.UseHttpsRedirection();


app.MapControllers();

app.Run();







//builder.Services.AddDbContext<AppDbContext>(opt =>
//        opt.UseInMemoryDatabase("InMem"));
//builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


//var app = builder.Build();



//// Configure the HTTP request pipeline.


//app.UseHttpsRedirection();

//PrepDb.PrepPopulation(app);

//app.Run();