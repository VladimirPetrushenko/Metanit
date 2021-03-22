using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateMyServicesCore3._0.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Sedn by SMS";
        }
    }
}
