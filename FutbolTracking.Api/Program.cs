using FutbolTracking.Application.Contracts;
using FutbolTracking.Application.Services;
using FutbolTracking.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<ApplicationDbContext>());
builder.Services.AddScoped<ILeagueService, LeagueService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sample endpoints for testing
app.MapGet("/api/health", () => new { Status = "Healthy", Timestamp = DateTime.UtcNow })
    .WithName("GetHealth");

app.MapPost("/api/leagues", async (AddLeagueRequest request, ILeagueService service, CancellationToken ct) =>
{
    var league = await service.AddLeagueAsync(request, ct);
    return Results.Created($"/api/leagues/{league.Id}", league);
}).WithName("AddLeague");

app.Run();
