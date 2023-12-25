using GenericController.Intefaces;
using GenericController.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString("Connection"));
//});
builder.Services.AddTransient<IPersonService, PersonService>();
builder.Services.AddTransient<ICourseService, CourseService>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
