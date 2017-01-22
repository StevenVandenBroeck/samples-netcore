using System;
using System.Collections.Generic;

namespace Samples.Business
{
    public class MessageStore : IMessageStore
    {
        private List<string> _messages = new List<string>();
        public IEnumerable<string> Messages
        {
            get { return _messages; }
        }

        public void AddMessage(string sender, string message)
        {
            var msg = String.Format($"({0}-{1} : {2}", DateTime.Now, sender ?? "null", message ?? "null");
            _messages.Add(msg);
        }
    }
}
