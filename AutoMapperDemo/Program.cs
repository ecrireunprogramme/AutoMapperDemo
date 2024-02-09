using System.Reflection;
using AutoMapper;
using AutoMapperDemo.DTOs;
using AutoMapperDemo.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/colis", (IMapper mapper) => {
    var colis = GetColis();

    var colisDto = mapper.Map<ColisDto>(colis);

    return colisDto;
})
.WithName("GetColis")
.WithOpenApi();

app.MapPost("/colis", (IMapper mapper,
                        ColisDto colisDto) => {

    var colis = mapper.Map<Colis>(colisDto);

    return colis;
})
.WithName("PostColis")
.WithOpenApi();

app.MapGet("/colises", (IMapper mapper) => {
    
    var listColisDto = mapper.ProjectTo<ColisDto>(GetListColis().AsQueryable());

    return listColisDto;
})
.WithName("GetColises")
.WithOpenApi();


app.Run();

    
static IEnumerable<Colis> GetListColis()
{
    return [
        new Colis {
            Id = 10,
            SenderName = "Momo Jaures",
            SenderPhone = "699493400",
            ReceiverName = "Ivan Doumtsop",
            ReceiverPhone = "690389400",
            CreatedBy = "admin",
            DeliveryAddress = new Address
            {
                StreetName = "William Andem",
                StreetNumber = 67,
                City = "Douala",
                Country = "Cameroun",
                PostalCode = "e3er3w"
            }
        },
        new Colis {
            Id = 134,
            SenderName = "Medard Teguia",
            SenderPhone = "6954289250",
            ReceiverName = "Atanase Tankeu",
            ReceiverPhone = "698754182",
            CreatedBy = "admin",
            DeliveryAddress = new Address
            {
                StreetName = "William Andem",
                StreetNumber = 50,
                City = "Douala",
                Country = "Cameroun",
                PostalCode = "59E3F"
            }
        }
    ];
}

static Colis GetColis()
{
    return new Colis
    {
        Id = 10,
        SenderName = "Darius Tsafack",
        SenderPhone = "699493400",
        ReceiverName = "Ivan Woukeng",
        ReceiverPhone = "690389400",
        CreatedBy = "admin",
        DeliveryAddress = new Address
        {
            StreetName = "William Andem",
            StreetNumber = 50,
            City = "Douala",
            Country = "Cameroun",
            PostalCode = "59E3F"
        }
    };
}
