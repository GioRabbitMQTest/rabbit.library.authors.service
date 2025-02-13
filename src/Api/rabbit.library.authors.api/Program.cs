
using rabbit.library.authors.infraestrucure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfraestructureService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();

//add-migration AuthorInitial -Context ApplicationDbContext -o Persistence/Migrations