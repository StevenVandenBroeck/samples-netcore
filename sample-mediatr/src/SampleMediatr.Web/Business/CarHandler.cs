using System;
using Samples.ViewModels;
using Microsoft.Extensions.Logging;

namespace Samples.Business
{
    public class CarHandler : ICarHandler
    {
        public CarHandler(ILogger<CarHandler> logger)
        {
            _logger = logger;
        }

        private readonly ILogger<CarHandler> _logger;

        public void Handle(Car car)
        {
            _logger.LogWarning("From CarHandler : Brand = {CarBrand}, Model = {CarModel}, Color = {CarColor}", car.Brand, car.Model, car.Color);
        }
    }
}
