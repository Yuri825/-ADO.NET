using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask4CodeFirst
{
    class Actors
    {
        [Key]
        public int ActorID { get; set; }
        public string Name { get; set; }
        public string Citizen { get; set; }
        public int Age { get; set; }
    }
}
