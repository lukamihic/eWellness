using AutoMapper;
using eWellness.API.Mapping;
using eWellness.BL;
using eWellness.BL.Common;
using eWellness.Core;
using eWellness.DL;
using eWellness.DL.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(options =>
options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Main")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Automapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Service mappings
//// ActivityLogs
builder.Services.AddScoped<IActivityLogRepository, ActivityLogRepository>();
builder.Services.AddScoped<IActivityLogService, ActivityLogService>();
//// Users
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
//// Tips
builder.Services.AddScoped<ITipRepository, TipRepository>();
builder.Services.AddScoped<ITipService, TipService>();
//// ServiceCategories
builder.Services.AddScoped<IServiceCategoryRepository, ServiceCategoryRepository>();
builder.Services.AddScoped<IServiceCategoryService, ServiceCategoryService>();
//// SpecialOffers
builder.Services.AddScoped<ISpecialOfferRepository, SpecialOfferRepository>();
builder.Services.AddScoped<ISpecialOfferService, SpecialOfferService>();


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
