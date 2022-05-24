using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sinemam.Core.Repositories;
using Sinemam.Core.Services;
using Sinemam.Core.UnitOfWork;
using Sinemam.Repository.Repository;
using Sinemam.Repository.Unitofworks;
using Sinemam.Service.Mappings;
using Sinemam.Service.Services;
using Sinemam.Service.Validations;
using Sinemam.WebAPI.Filters;
using Sinemam.WebAPI.Middleware;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//////////////////////// Add generic scope/////////////////////////////////
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IGenericUnitOfWork, Unitofwork>();
builder.Services.AddAutoMapper(typeof(ModelDtoMap));
//////////////////Repository scope////////////////////////////////////////
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IShowRepository, ShowRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//////////////////Service scope////////////////////////////////////////
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShowService,ShowService>();
builder.Services.AddScoped<ICommentService, CommentService>();
//////////////////Validation Control////////////////////////////////////////
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CategoryDtoValidator>());
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CommentDtoValidator>());
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ShowDtoValidator>());
builder.Services.AddControllers(options => options.Filters.Add(new ValidateFilterAttribute())).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<UserDtoValidator>());
builder.Services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });


builder.Services.AddDbContext<Sinemam.Repository.AppDbContexts.AppContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(Sinemam.Repository.AppDbContexts.AppContext)).GetName().Name);

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
