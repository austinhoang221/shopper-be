using Paris.RMS.Cms.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var withApiVersioning = builder.Services.AddDefaultVersioning();
builder.AddDefaultOpenApi(withApiVersioning);

var app = builder.Build();

var paymentOrganizations = app.NewVersionedApi("Products");
paymentOrganizations.MapProductApisV1();

// Configure the HTTP request pipeline.
app.UseDefaultOpenApi();

app.Run();
