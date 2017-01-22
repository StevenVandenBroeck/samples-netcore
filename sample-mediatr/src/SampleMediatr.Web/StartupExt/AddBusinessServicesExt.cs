using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SampleMediatr.Web.Eventing;
using Samples.Business;

namespace Sample.Web
{
    public static class AddBusinessServicesExt
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICarHandler, CarHandler>();
            services.AddScoped<IMessageStore, MessageStore>();

            //services.AddScoped<IRequestHandler<CarRequest>, CarRequestHandler>();
            services.AddScoped<IAsyncRequestHandler<CarRequest>, CarAsyncRequestHandler>();

            services.AddScoped<INotificationHandler<CarNotification>, CarNotificationHandler1>();
            services.AddScoped<INotificationHandler<CarNotification>, CarNotificationHandler2>();

            return services;
        }
    }
}
