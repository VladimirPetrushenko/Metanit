using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateMyServicesCore3._0.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send by Email";
        }
    }
}
