using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using SCM.Helper;
using SCM.Interfaces;
using SCM.Interfaces.Item;
using SCM.Interfaces.Items;
using SCM.Model;
using SCM.Model.Items;
using SCM.Services.Categorys;
using SCM.Services.Items;
using SCM.Services.Requisition;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SCMContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("SCMContext")));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
builder.Services.AddTransient<IItemService, ItemService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IRequisitionService, RequisitionService>();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

/*if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") != "Development")
{
    app.Urls.Add("http://74.208.32.241:84");
    app.Urls.Add("http://localhost:84");
}
*/
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
