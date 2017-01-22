using System;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;

namespace SampleMediatr.Web.Eventing
{
    public class CarNotificationHandler2 : INotificationHandler<CarNotification>
    {
        public CarNotificationHandler2(ILogger<CarNotificationHandler2> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<CarNotificationHandler2> _logger;

        public void Handle(CarNotification notification)
        {
            Thread.Sleep(2000);
            _logger.LogWarning("{Handler} : Brand = {CarBrand}, Model = {CarModel}, Color = {CarColor}", this.GetType().Name, notification.Brand, notification.Model, notification.Color);
        }
    }
}
