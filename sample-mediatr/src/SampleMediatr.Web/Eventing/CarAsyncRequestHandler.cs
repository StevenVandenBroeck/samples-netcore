using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace SampleMediatr.Web.Eventing
{
    public class CarAsyncRequestHandler : IAsyncRequestHandler<CarRequest>
    {
        public CarAsyncRequestHandler(ILogger<CarAsyncRequestHandler> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<CarAsyncRequestHandler> _logger;

        public async Task Handle(CarRequest message)
        {
            Thread.Sleep(2000);
            _logger.LogWarning("{Handler} : Brand = {CarBrand}, Model = {CarModel}, Color = {CarColor}", this.GetType().Name, message.Brand, message.Model, message.Color);
            return;
        }
    }
}
