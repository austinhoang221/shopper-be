var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
var withApiVersioning = builder.Services.AddDefaultVersioning();
builder.AddDefaultSwashbuckle(withApiVersioning);

builder.AddDefaultAuthentication();

builder.Services
    .RegisterServices()
    .RegisterValidator()
    .RegisterUseCasesLayer()
    .RegisterPersistenceLayer(builder.Environment)
    ;

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseDefaultSwashbuckle();

app.UseDefaultAuthentication();

app.MapControllers();

app.Run();
