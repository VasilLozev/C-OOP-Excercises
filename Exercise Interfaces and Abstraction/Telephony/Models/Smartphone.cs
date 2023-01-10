using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Exceptions;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ISmartphone
    {
        
        public string Call(string phoneNumber)
        {
            if (!this.ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
        public string BrowseURL(string url)
        {
            if (!this.ValidateURL(url))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(ch => char.IsDigit(ch));
        private bool ValidateURL(string url)
            => url.All(ch => !char.IsDigit(ch));
    }
}
