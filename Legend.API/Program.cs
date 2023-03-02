var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.Environment.IsDevelopment();

/*builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services..AddTransient<IDeveloperRepository, DeveloperRepository>();
builder.Services..AddTransient<IProjectRepository, ProjectRepository>();*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

