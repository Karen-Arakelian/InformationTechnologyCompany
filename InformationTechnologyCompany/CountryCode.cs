using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class CountryCode
    {
        static readonly string[] countrysCodes = { "+374", "+7", "+46" };

        public static string OneCountryCode()
        {
            var rand = new Random();
            int index = rand.Next(0, countrysCodes.Length);
            string countryCode = countrysCodes[index];

            return countryCode;
        }
    }
}
