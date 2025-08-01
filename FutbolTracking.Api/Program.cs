var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
