using System;
using System.Collections.Generic;

namespace Samples.Business
{
    public interface IMessageStore
    {
        IEnumerable<string> Messages { get; }
        void AddMessage(string sender, string message);
    }
}
