using YesNo.Api.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IYesNoService>(new YesNoService());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
