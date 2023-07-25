using CommandQueryResponsibilitySegregation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StudentContext>(opt =>
{
    opt.UseSqlServer("server=LAPTOP-TTJ08ARE\\SQLEXPRESS; database=Student_CQRS_DB; Trusted_Connection=true;");
});
builder.Services.AddMediatR(typeof(Program));

builder.Services.AddControllers().AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

var app = builder.Build();


app.MapControllers();
app.Run();
