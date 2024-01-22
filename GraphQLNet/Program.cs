
using GraphQLNet.DataContext;
using GraphQLNet.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IOpportunityRepository, OpportunityRepository>();
string AllowedOrigin = "allowedOrigin";
builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowedOrigin",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
        );
});
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseCors(AllowedOrigin);
app.UseWebSockets();
app.UseRouting();

app.Run();