var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var withApiVersioning = builder.Services.AddDefaultVersioning();
builder.AddDefaultOpenApi(withApiVersioning);

//Add MVC Lowercase URL
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = false;
});

builder.Services
    .AddMediatR(configuration =>
    {
        configuration.RegisterServicesFromAssembly(typeof(Program).Assembly);
    });

builder.Services
    .RegisterServices()
    .RegisterValidator()
    .RegisterPersistenceLayer(builder.Environment)
    ;


var app = builder.Build();

var paymentOrganizations = app.NewVersionedApi("Products");
paymentOrganizations.MapProductApisV1();

// Configure the HTTP request pipeline.
app.UseDefaultOpenApi();

app.Run();
