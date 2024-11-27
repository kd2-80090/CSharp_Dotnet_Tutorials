using Microsoft.AspNetCore.Mvc.Formatters;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("https://localhost:44321/") // Replace with your frontend's URL
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


builder.Services.AddControllers(options =>
{
    options.OutputFormatters.Clear();  // Clears all the default formatters
    options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());  // Only XML
})
.AddXmlDataContractSerializerFormatters();  // Add support for XML input (optional, depends on use case)


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
