using PMP.Models;
using PMP.DAL;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/welcome", () => "welcome to IET!");

app.MapGet("/activities",() => {
    List<Activity> l = ProjectDBManager.GetAll();
    return l;
});

app.Run();