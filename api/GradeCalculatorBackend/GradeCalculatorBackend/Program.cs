var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Change the Swagger endpoint to a different route
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        // Remove this line or change it to false if you don't want Swagger as the default route
        c.RoutePrefix = "swagger";
    });
}

// These must come before MapControllers
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthorization();
app.MapControllers();

app.Run();