using CameraServer.Models;
using CameraServer.Services;

var builder = WebApplication.CreateBuilder(args);
#if DEBUG
builder.WebHost.UseKestrel(options =>
{
    options.ListenAnyIP(5000);    
});
#endif
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CameraSimulatorContext>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();