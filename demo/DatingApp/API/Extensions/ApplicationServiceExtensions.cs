using API.Data;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using API.Repository;
using API.Services;
using API.SignalR;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
    IConfiguration config)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(opt =>
         {
             opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
         });
        services.AddCors();

        // Lifetime of Services
        // - AddSingleton - Created the first time they are requested
        // Every subsequent request for that service, will use the same instance
        // Good for caching data or maintain a state that should be shared across the application
        // - AddTransient - Created each time they are requested
        // Good for lightweight services
        // - AddScoped - Created once per client request (HTTP request)
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ILikesRepository, LikesRepository>();
        services.AddScoped<IMessageRepository, MessageRepository>();
        services.AddScoped<IPhotoRepository, PhotoRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPhotoService, PhotoService>();
        services.AddScoped<LogUserActivity>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
        services.AddSignalR();
        services.AddSingleton<PresenceTracker>();

        return services;

    }
}