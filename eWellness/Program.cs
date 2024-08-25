using AutoMapper;
using eWellness.API.Mapping;
using eWellness.BL;
using eWellness.BL.Common;
using eWellness.Core;
using eWellness.DL;
using eWellness.DL.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Ensure SQL server is connected
Task.Delay(15000);

// Add services to the container.
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Main"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5, // Number of retry attempts
                maxRetryDelay: TimeSpan.FromSeconds(10), // Delay between retries
                errorNumbersToAdd: null // List of error numbers to consider for retries
            );
        }
    )
);

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
//// Clients
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IClientService, ClientService>();
//// Employees
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
//// PaymentMethods
builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddScoped<IPaymentMethodService, PaymentMethodService>();
//// Payments
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
//// Invoices
builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
//// Services
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IServiceService, ServiceService>();
//// Appointments
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

// RabbitMQ
builder.Services.AddScoped<IRabbitMQProducer, RabbitMQProducer>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var maxRetryCount = 10;
    var retryDelay = TimeSpan.FromSeconds(10);

    for (int retryAttempt = 0; retryAttempt < maxRetryCount; retryAttempt++)
    {
        try
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
            dbContext.Database.Migrate();
            break;  // Exit the loop if successful
        }
        catch (Exception ex)
        {

            // Wait before the next retry attempt
            Thread.Sleep(retryDelay);
        }
    }
}

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.Urls.Add("http://*:5000");  // Add this line


app.UseCors(builder =>
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
