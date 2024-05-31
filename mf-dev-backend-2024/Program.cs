using mf_dev_backend_2024.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Linha abaixo serve pra aplicar altera��es instantaneas na view durante a compila��o do sistema
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
//1- � criado um modelo de dados, criando uma classe de contexto chamada AppDbContext
//2- Configurado a string de conex�o com o banco de dados no arquivo appsettings.json
//3- A baixo estamos passando essa configura��o de banco de dados por inje��o de depend�ncia
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

/// A classe program � repons�vel por configurar o projeto
