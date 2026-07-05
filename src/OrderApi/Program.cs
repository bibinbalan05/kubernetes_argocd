using System.Net.Http.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => Results.Ok(new { service = "OrderApi", status = "running" }));
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));
app.MapGet("/orders", async (IHttpClientFactory httpClientFactory, IConfiguration configuration) =>
{
    var baseUrl = configuration["ProductApi:BaseUrl"] ?? "http://product-api-service";
    var client = httpClientFactory.CreateClient();
    var products = await client.GetFromJsonAsync<List<ProductDto>>($"{baseUrl}/products");

    return Results.Ok(new[]
    {
        new { id = 1001, productId = 1, quantity = 2, status = "Confirmed", productName = products?.FirstOrDefault(p => p.Id == 1)?.Name ?? "Unknown" },
        new { id = 1002, productId = 2, quantity = 1, status = "Pending", productName = products?.FirstOrDefault(p => p.Id == 2)?.Name ?? "Unknown" }
    });
});

app.Run();

record ProductDto(int Id, string Name, decimal Price, int Stock);
