using AspNetCore.DependencyInjection;
using AspNetCore.DependencyInjection.ServiceLifetime;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddMyDependencyGroup()
                .AddServiceLifetime();

var app = builder.Build();


app.MapGet("/", (ITransientGuid transientGuid1, ITransientGuid transientGuid2,
                              IScopedGuid scopedGuid1, IScopedGuid scopedGuid2,
                              ISingletonGuid singletonGuid1, ISingletonGuid singletonGuid2) =>
{
    return $"transient1 : {transientGuid1.getGuid()} \n" +
               $"transient2 : {transientGuid2.getGuid()} \n" +
               $"scoped1 : {scopedGuid1.getGuid()} \n" +
               $"scoped2 : {scopedGuid2.getGuid()} \n" +
               $"singleton1 : {singletonGuid1.getGuid()} \n" +
               $"singleton2 : {singletonGuid2.getGuid()}";
});

app.Run();
