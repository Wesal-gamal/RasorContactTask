using ContactTask.Server.Models;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//builder.Services.AddSwaggerGen();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
//});
builder.Services.AddDbContext<ContactContext>(options => options.UseInMemoryDatabase(builder.Configuration.GetConnectionString
    ("MyTestDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//if (app.Environment.IsDevelopment())
//{
//    // Enable middleware to serve generated Swagger as a JSON endpoint
//    app.UseSwagger();

//    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
//    // specifying the Swagger JSON endpoint
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
//        // Uncomment the line below to serve the Swagger UI at the app's root
//        // c.RoutePrefix = string.Empty;
//    });
//}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
