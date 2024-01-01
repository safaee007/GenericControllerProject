using GenericController.Intefaces;
using GenericController.Services;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program)); //AppDomain.CurrentDomain.GetAssemblies()

builder.Services.AddControllers();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString("Connection"));
//});
builder.Services.AddTransient<IPersonService, PersonService>();
builder.Services.AddTransient<ICourseService, CourseService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
