using System;
using System.Text.RegularExpressions;

namespace BankEncapsulationconsol
{
    public class PersonalInformation
    {

        
               
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Zip { get; set; }

        private string phoneNumber = "";

        public string FormattedNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = Regex.Replace($"{value}", @"(\d{ 3})(\d{ 4})", "$1-$2-$3");
            }

        }
    }

}            
        
            

      


