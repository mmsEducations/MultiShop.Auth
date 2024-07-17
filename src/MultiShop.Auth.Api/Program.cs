using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MultiShop.Auth.Api.Data;
using MultiShop.Auth.Api.Data.Entites;

var builder = WebApplication.CreateBuilder(args);


//1.Adým MVC yapýsýný dahil et
builder.Services.AddControllers();//Asp.Net Core MVC altyapýsýný uygulamamýza dahil etmemizi saðlar

//Swagger 1
builder.Services.AddEndpointsApiExplorer(); //Swaggerin apiyi incelemesi ve belgelerin oluþturulmasý 
builder.Services.AddSwaggerGen();//Swagger belgeleri için gerekli tüm ayarlarýn yapýlandýrýlmasý

//Database Configuration

builder.Services.AddDbContext<MultiShopAuthDbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); //mSsql db 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Microsft ýdentity configuration
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
       .AddEntityFrameworkStores<MultiShopAuthDbContext>()
       .AddDefaultTokenProviders();




var app = builder.Build();

//Swagger 2
if (app.Environment.IsDevelopment())//Swagger'i Development sadecce ortamýnda aktifleþtirir
{
    app.UseSwagger();  //Apilerin yaptýðý iþlemleri ve bu iþlemlerin nasýl kullanýlacaðýný açýklayan metadalardýr 
    app.UseSwaggerUI();//Apilerin görsel ayarlamalarý'ný aktif hale getirir
}

//2.Adým MVC Controller'a Yönlendirme
app.MapControllers(); //Asp.Net Core uygulamasýndaki http isteklerini Api'nin Controller'ýna yönelerimeyi saðlar



app.Run();
