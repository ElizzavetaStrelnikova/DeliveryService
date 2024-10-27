using DeliveryServiceSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var districtService = new DistrictService();
var districts = districtService.LoadDistricts("C:\\Users\\eliza\\source\\repos\\DeliveryService\\Data\\Districts.json");
var orderService = new OrderService();
var orders = orderService.LoadOrders("C:\\Users\\eliza\\source\\repos\\DeliveryService\\Data\\Orders.json");
builder.Services.AddSingleton(districts);
builder.Services.AddSingleton(orders);
builder.Services.AddSingleton(new DeliveryService(districts, orders));

var app = builder.Build();

app.UseStaticFiles();

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
