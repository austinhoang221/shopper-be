var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var withApiVersioning = builder.Services.AddDefaultVersioning();
builder.AddDefaultSwashbuckle(withApiVersioning);

builder.Services
    .AddMediatR(configuration =>
    {
        configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
    });

builder.AddDefaultAuthentication();

builder.Services
    .RegisterServices()
    .RegisterValidator()
    .RegisterPersistenceLayer(builder.Environment)
    ;

var app = builder.Build();

var products = app.NewVersionedApi("Products");
products.MapProductApisV1()
    .RequireAuthorization();

// Configure the HTTP request pipeline.
app.UseDefaultAuthentication();
app.UseDefaultSwashbuckle();

app.Run();
