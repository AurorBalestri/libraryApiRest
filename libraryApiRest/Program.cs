using libraryApiRest.FileHelper;
using libraryApiRest.Models;
using libraryApiRest.Services;
using libraryApiRest.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IBookService, BookService>();
builder.Services.AddSingleton<IList<Book>, List<Book>>();
builder.Services.AddSingleton<IBorrowService, BorrowService>();
builder.Services.AddSingleton<IList<Borrow>, List<Borrow>>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddSingleton<IList<Customer>, List<Customer>>();



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
