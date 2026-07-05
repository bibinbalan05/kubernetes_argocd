var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => Results.Ok(new { service = "ProductApi", status = "running" }));
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));
app.MapGet("/config", () => Results.Ok(new
{
    connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"] ?? "not-set"
}));
app.MapGet("/products", () =>
{
    return Results.Ok(new[]
    {
        new { id = 1, name = "Laptop", price = 999.99m, stock = 10 },
        new { id = 2, name = "Mouse", price = 29.99m, stock = 50 }
    });
});

app.Run();
