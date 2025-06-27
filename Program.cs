using BlazorWebSample.Components;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient();

var app = builder.Build();

FileExtensionContentTypeProvider extensionProvider = new();
extensionProvider.Mappings.Add(".dll", "application/octet-stream");
extensionProvider.Mappings.Add(".dat", "application/octet-stream");
extensionProvider.Mappings.Add(".blat", "application/octet-stream");

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = extensionProvider
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
