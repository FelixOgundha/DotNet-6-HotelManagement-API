using HotelManager.API.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//1. Adding Serilog to log our app Data
builder.Host.UseSerilog((ctx, lc) => lc
    .WriteTo.Console()
    .WriteTo.Seq("http://localhost:5341")
    .ReadFrom.Configuration(ctx.Configuration));

Log.Information("Hello Felix System is Starting up...");


try
{
    // Add services to the container.
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //Adding Cross Origin Resource Sharing
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("ÄllowAll", b => b.AllowAnyHeader().
        AllowAnyOrigin().
        AllowAnyMethod());
    });
    builder.Services.AddDbContext < HotelManagerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelDbContext")));
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseSerilogRequestLogging();

    app.UseHttpsRedirection();

    app.UseCors("AllowAll");
    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}


