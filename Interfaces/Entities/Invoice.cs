using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Basic Payment: {BasicPayment:c}");
            stringBuilder.AppendLine($"Tax: {Tax:c}");
            stringBuilder.AppendLine($"Total payment: {TotalPayment:c}");

            return stringBuilder.ToString();
        }
    }
}
