using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFirst.Model;

namespace CodeFirst
{
    [Table("VipOrders")]
    public class VipOrder : Order
    {
        public string status { get; set; }

       
    }
}
