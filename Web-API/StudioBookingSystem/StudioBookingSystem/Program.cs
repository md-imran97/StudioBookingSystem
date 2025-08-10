using Microsoft.EntityFrameworkCore;
using StudioBookingSystem.Repository.Database;
using StudioBookingSystem.Repository.Repository;
using StudioBookingSystem.Repository.RepositoryInterface;
using StudioBookingSystem.Service.Interface;
using StudioBookingSystem.Service.Service;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddScoped<IStudioRepository,StudioRepository>();
        builder.Services.AddScoped<IBookingRepository,BookingRepository>();
        builder.Services.AddScoped<IStudioService, StudioService>();
        builder.Services.AddScoped<IBookingService, BookingService>();

        builder.Services.AddControllers();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            });
        });

        var app = builder.Build();
        app.UseCors("AllowAll");

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}