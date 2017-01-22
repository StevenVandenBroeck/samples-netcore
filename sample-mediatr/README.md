# MediatR Sample

Shows the usage of MediatR v3.

## Add MediatR to project

Add the MediatR package to the project json :

```json
"MediatR": "3.0.0"
``` 

Register the instance factories and the IMediatr interface in the **ConfigureServices** method of the **Startup** class :

```csharp
services.AddScoped<MediatR.IMediator, MediatR.Mediator>();
services.AddScoped<MediatR.SingleInstanceFactory>(p => t => p.GetRequiredService(t));
services.AddScoped<MediatR.MultiInstanceFactory>(p => t => p.GetServices(t));

´´´  


