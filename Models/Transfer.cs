using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransferService.Models
{
    public class Transfer
    {
        public string FromAccount { get; set; }
        public string BeneName { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }

        public string strJSON { get; set; }
    }
}