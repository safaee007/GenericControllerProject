var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//{
//    options.UseSqlServer(Configuration.GetConnectionString("Connection"));
//});
//builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
//builder.Services.AddScoped<IPersonRepository, PersonRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
