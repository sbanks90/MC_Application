using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Application
{
    class Client
    {
        public int ClientId { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }        
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }

        public string FullClientInfo
        {
            get
            {
                return $"{ClientId} {ClientCode} {ClientName} {BillingAddress} {ShippingAddress} {ContactName} {ContactEmail} {PhoneNumber}";
            }
        }
    }
}
