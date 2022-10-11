using SallesWebMvc.Models.Enums;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus status { get; set; }
        public Seller Seller{ get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            this.status = status;
            Seller = seller;
        }

    }
}
