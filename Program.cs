using Microsoft.AspNetCore.Identity;
using NLog;
using PresenceManagement.Controllers.Log;
using PresenceManagement.DataAccess.DBContexts;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Ilog, Log>();
builder.Services.AddDbContext<PresenceManagementContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("AbonnementCs"));
});
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//.AddEntityFrameworkStores<PresenceManagementContext>()
//.AddDefaultTokenProviders();
//
//builder.Services.AddAuthentication(options =>
//{
//   options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//   options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//   options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//});
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
