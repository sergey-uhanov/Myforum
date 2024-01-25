using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Myforum.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RazorPagesUsersConnection");


builder.Services.AddDbContext<RazorPagesUsers>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddDefaultIdentity<RazorUsers>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<RazorPagesUsers>();

builder.Services.AddScoped<UserManager<RazorUsers>, UserManager<RazorUsers>>();


// Добавление сервисов для аутентификации и авторизации
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

// Добавление сервисов для Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
