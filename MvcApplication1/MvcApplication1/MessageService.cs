using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    public interface IMessageService
    {
        List<string> Get();
        void Add(string msg);
    }

    public class MessageService : IMessageService
    {
        
        List<string> _messages = new List<string>();
        #region IMessageService Members

        public List<string> Get()
        {
            return _messages;
        }

        public void Add(string msg)
        {
            _messages.Add(msg);
        }

        #endregion
    }
}