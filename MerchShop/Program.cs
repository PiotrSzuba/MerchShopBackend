using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MerchShop.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MerchShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MerchShopContext")));

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .WithOrigins("http://localhost:3000") // Allow only this origin can also have multiple origins separated with comma
    .AllowCredentials());

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
