using CameraServer.Models;
using CameraServer.ModelsService;


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
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddScoped<ISendMailService,SendService>();
//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromMinutes(1);
//    options.Cookie.HttpOnly = true;
//    options.Cookie.IsEssential = true;
//    options.Cookie.Name = "Session";
//});

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

// app.UseSession();

app.MapControllers();

app.Run();