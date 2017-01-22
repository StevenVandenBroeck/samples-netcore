using System;
using MediatR;
using Samples.ViewModels;

namespace SampleMediatr.Web.Eventing
{
    public class CarNotification : Car, INotification
    { }
}
