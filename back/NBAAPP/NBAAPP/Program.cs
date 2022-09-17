using Microsoft.EntityFrameworkCore;
using NBAAPP.Controllers;
using NBAAPP.Data;
using NBAAPP.Interface.Manager;
using NBAAPP.Interface.Provider;
using NBAAPP.Manager;
using NBAAPP.Provider;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options => options.AddPolicy(name: "NBAOrigins",
    policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    }));
builder.Services.AddScoped<IPlayerProvider, PlayerProvider>();
builder.Services.AddScoped<IPlayerManager, PlayerManager>();
builder.Services.AddScoped<ITeamManager, TeamManager>();
builder.Services.AddScoped<ITeamProvider, TeamProvider>();
builder.Services.AddScoped<DbContext, DataContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("NBAOrigins");
app.UseAuthorization();

app.MapControllers();

app.Run();
