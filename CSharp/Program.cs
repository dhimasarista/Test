using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

// Data dari kode PHP
var sampleData = new[]
{
    new Data(1, "John Doe", "Jalan ABC", "Jakarta"),
    new Data(2, "Jane Doe", "Jalan DEF", "Bandung"),
    new Data(3, "Bob Smith", "Jalan GHI", "Surabaya")
};

// Endpoint utama
app.MapGet("/", () => new ApiResponse(sampleData));

app.Run();

// Model untuk data
public record Data(int Id, string? Nama, string? Alamat, string? Kota);

// Model untuk API response
public record ApiResponse(Data[] Data);

[JsonSerializable(typeof(Data[]))]
[JsonSerializable(typeof(ApiResponse))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}
