using Microsoft.EntityFrameworkCore;
using Infrastructure.Command;
using Infrastructure.Persistence;
using Infrastructure.Query;
using Application.Interface.Cliente;
using Application.UseCase;
using Application.Mapper.IMapper;
using Application.Mapper;
using Application.Interface.Receipt;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<ApiContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddScoped<IClienteServices, ClientServices>();
builder.Services.AddScoped<IClienteQuery, ClienteQuery>();
builder.Services.AddScoped<IClienteCommand, ClienteCommand>();
builder.Services.AddScoped<IClientMapper, ClientMapper>();

builder.Services.AddScoped<ICobranzaServices, ReceiptServices>();
builder.Services.AddScoped<ICobranzaQuery, CobranzaQuery>();
builder.Services.AddScoped<ICobranzaCommand, CobranzaCommand>();
builder.Services.AddScoped<ICobranzaMapper, CobranzaMapper>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
