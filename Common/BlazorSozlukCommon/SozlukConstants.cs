using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozlukCommon
{
    
    public class SozlukConstants
    {
        public const string RAbbitMQHost = "localhost";
        public const string DefaultExchangeType= "direct";

        public const string UserEmailExchangeName = "UserExchange";
        public const string UserEmailChangedQueueName= "UserEmailChangedQueue";

    }
}

