using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr_lab2.Services
{
    internal class CryptoConverter
    {
        public decimal ConvertToHryvnia(decimal amount, string crypto)
        {
            return crypto switch
            {
                "BTC" => amount * 110000m,
                "ETH" => amount * 3800m,
                "SOL" => amount * 190m,
                _ => throw new ArgumentException("Unknown crypto type")
            };
        }
    }
}
