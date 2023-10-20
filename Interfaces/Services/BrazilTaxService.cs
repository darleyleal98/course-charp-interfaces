using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            return (amount <= 100.00) ? amount * 0.2 : amount * 0.15;
        }
    }
}