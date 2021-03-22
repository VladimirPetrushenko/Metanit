using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateMyServices
{
    public interface IMessageSender
    {
        string Send();
    }

    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send by Email";
        }
    }
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Sedn by SMS";
        }
    }
}
