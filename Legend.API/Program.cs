using Legend.Services;
using Legend.Services.Interfaces;
using Legend.Data.ServiceExtension;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient(typeof(ILegendRepository<>), typeof(LegendRepository<>));
/*builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<ICharacterRepository, CharacterRepository>();
builder.Services.AddTransient<IMissionRepository, MissionRepository>();
*/
// Add services to the container.
builder.Services.AddDIServices(builder.Configuration);
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();

builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.UseMemberCasing();
    });
   

builder.Services.AddApiVersioning(opt =>
{
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.ReportApiVersions = true;
    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                    new HeaderApiVersionReader("x-api-version"),
                                                    new MediaTypeApiVersionReader("x-api-version"));
});
// Add ApiExplorer to discover versions
builder.Services.AddVersionedApiExplorer(setup =>
{
    setup.GroupNameFormat = "'v'VVV";
    setup.SubstituteApiVersionInUrl = true;
});

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



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

