using OngApi.Gateways;
using OngApi.Interfaces.Gateways;
using OngApi.Interfaces.UseCases;
using OngApi.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPedidoUseCase, PedidoUseCase>();
builder.Services.AddScoped<IDoacaoUseCase, DoacaoUseCase>();
builder.Services.AddScoped<IOngUseCase, OngUseCase>();

builder.Services.AddScoped<IOngGateway, OngGateway>();
builder.Services.AddScoped<IPedidoGateway, PedidoGateway>();
builder.Services.AddScoped<IProdutoGateway, ProdutoGateway>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
