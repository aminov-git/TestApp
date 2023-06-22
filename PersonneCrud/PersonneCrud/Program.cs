using Microsoft.EntityFrameworkCore;
using PersonneCrud.DbContexts;
using PersonneCrud.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at
// https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddDbContext<PersonneContext>(
    dbContextOptions => dbContextOptions.UseSqlite(
        builder.Configuration["ConnectionStrings:PersonneDBConnectionString"]));

builder.Services.AddScoped<IPersonneRepository, PersonneRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
