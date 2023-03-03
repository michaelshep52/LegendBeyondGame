using Legend.Data.Repositories;
using Legend.Domain.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

//builder.Services.AddTransient(typeof(ILegendRepository<>), typeof(LegendRepository<>));
/*builder.Services..AddTransient<IUserRepository, UserRepository>();
builder.Services..AddTransient<ICharacterRepository, CharacterRepository>();
builder.Services..AddTransient<IMissionRepository, MissionRepository>();*/


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

