using System;
using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using Samples.Business;

namespace SampleMediatr.Web.Eventing
{
    public class CarRequestHandler : IRequestHandler<CarRequest>
    {
        public CarRequestHandler(ILogger<CarRequestHandler> logger, IMessageStore messageStore)
        {
            _logger = logger;
            _messageStore = messageStore;
        }

        private readonly ILogger<CarRequestHandler> _logger;
        private readonly IMessageStore _messageStore;

        public void Handle(CarRequest message)
        {
            Thread.Sleep(2000);
            _logger.LogWarning("{Handler} : Brand = {CarBrand}, Model = {CarModel}, Color = {CarColor}", this.GetType().Name, message.Brand, message.Model, message.Color);
            _messageStore.AddMessage(this.GetType().Name, message.ToString());
        }
    }
}
