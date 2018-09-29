using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_databasefirst.Models
{
    public class _Credit
    {
        public int ID { get; set; }
        public DateTime Disburs { get; set; }
        public decimal Amount { get; set; }
        public string PersonName { get; set; }
    }
}
