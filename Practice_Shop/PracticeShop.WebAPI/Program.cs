using PracticeShop.BLL.Configuration;
using PracticeShop.DAL.Configuration;
using PracticeShop.WebAPI.Configuration;
using Microsoft.EntityFrameworkCore;
using PracticeShop.WebAPI;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddAPI()
    .AddDAL()
    .AddBLL();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
