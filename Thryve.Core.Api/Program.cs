using Microsoft.AspNetCore.Routing.Constraints;
using Thryve.Core.Api.Expenses;

var builder = WebApplication.CreateSlimBuilder(args);

// Register the regex route constraint
builder.Services.Configure<RouteOptions>(options =>
    options.SetParameterPolicy<RegexInlineRouteConstraint>("regex"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("/expenses").MapRoutes();

app.Run();
