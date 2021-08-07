using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Mikro_ORM_Web_API.Models
{
    public class SmallMerchant
    {
        [Key] //Merchant number is primary key.
        public int MerchantNumber { get; set; }
        public string MerchantName { get; set; }
        public string MerchantAddress { get; set; }
        public string MerchantContact { get; set; }
        public int TransactionAmount { get; set; }

    }
}
