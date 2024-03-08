using Microsoft.EntityFrameworkCore;
using Exam2Demo.Infrastructure;
using Exam2Demo.Infrastructure.UnitOfWork;
using Exam2Demo.Domain.UnitOfWork;
using Exam2Demo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"));
});


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient(typeof(IResidentService), typeof(ResidentService));
builder.Services.AddTransient(typeof(IApartmentService), typeof(ApartmentService));
builder.Services.AddTransient(typeof(IResidentApartmentService), typeof(ResidentApartmentService));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
