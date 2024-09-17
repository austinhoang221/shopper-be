var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var withApiVersioning = builder.Services.AddDefaultVersioning();
builder.AddDefaultOpenApi(withApiVersioning);

var app = builder.Build();

var paymentOrganizations = app.NewVersionedApi("Products");
paymentOrganizations.MapProductApisV1();

// Configure the HTTP request pipeline.
app.UseDefaultOpenApi();

string swaggerSpecUrl = "http://localhost:5283";
var document = await OpenApiDocument.FromUrlAsync(swaggerSpecUrl);

var settings = new TypeScriptClientGeneratorSettings
{
    ClassName = "{controller}Client",
};

var generator = new TypeScriptClientGenerator(document, settings);
var code = generator.GenerateFile();

app.Run();
