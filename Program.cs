using FBCreditCard;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("cardConnection")));

//Habilitammos los cors para que se pueda comunicar con ángular, le agregamos un policy pa que permita cualquier origen, cabecera y método
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
    build => build.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowWebApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
