using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design;
using MoviesDatabase.Data;

using Microsoft.Extensions.Hosting;
using MoviesDatabase.Models;

// Create app 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// Connection to db 
builder.Services.AddDbContext<ScriptureJournalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ScriptureJournalContext") ?? throw new InvalidOperationException("Connection string 'ScriptureJournalContext' not found.")));

// building 
var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
