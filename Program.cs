using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var services = new ServiceCollection();

services.AddSingleton<IFooService, FooService>()
.AddScoped<IBarService, BarService>()
.AddTransient<IBlaService, BlaService>();

using var rootContainer = services.BuildServiceProvider();

using var scopeA = rootContainer.CreateScope();
using var scopeB = rootContainer.CreateScope();

var scopeContainerA = scopeA.ServiceProvider;
var scopeContainerB = scopeB.ServiceProvider;


var blaService = scopeContainerA.GetRequiredService<IBlaService>();



blaService.Bla();


var blaService2 = scopeContainerB.GetRequiredService<IBlaService>();

blaService2.Bla();

