using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSolution.Web.ViewModels
{
    public class SalesOrderViewModel
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PONumber { get; set; }

        public string MessageToClient { get; set; }
    }
}