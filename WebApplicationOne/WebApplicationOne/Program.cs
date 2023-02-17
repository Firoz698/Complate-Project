using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebApplicationOne.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);



//ay data ta add kora hoyse 
builder.Services.AddDbContext<DataBaseUsm>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection"));
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

});



// Add services to the container.

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
