var builder = WebApplication.CreateBuilder(args);


//1.Adým MVC yapýsýný dahil et
builder.Services.AddControllers();//Asp.Net Core MVC altyapýsýný uygulamamýza dahil etmemizi saðlar

//Swagger 1
builder.Services.AddEndpointsApiExplorer(); //Swaggerin apiyi incelemesi ve belgelerin oluþturulmasý 
builder.Services.AddSwaggerGen();//Swagger belgeleri için gerekli tüm ayarlarýn yapýlandýrýlmasý


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
