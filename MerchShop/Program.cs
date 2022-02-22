using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MerchShop.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MerchShopContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MerchShopContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

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
