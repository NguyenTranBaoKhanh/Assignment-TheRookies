using BKShop.Data.EF;
using Microsoft.Extensions.Configuration;

using Microsoft.EntityFrameworkCore;
using BKShop.Application.Interfaces;
using BKShop.Application.Services;
using Microsoft.OpenApi.Models;
using AutoMapper;
using BKShop.ViewModels.ViewModels;
using BKShop.Data.Entities;
using BKShop.Application.System.Users;
using Microsoft.VisualStudio.Settings;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});
builder.Services.AddDbContext<BKShopDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "BKShop.Api", Version = "v1" });
});
//add automapper
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(Program).Assembly);
//Declare DI
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<IReviewService, ReviewService>();
//builder.Services.AddTransient<IStorageService, StorageService>();

// DI for identity
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<UserManager<User>, UserManager<User>>();
//builder.Services.AddTransient<SignInManager<User>, SignInManager<User>>();
//builder.Services.AddTransient<RoleManager<Role>, RoleManager<Role>>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BKShop.Api v1"));

}

app.UseCors("CORS");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
