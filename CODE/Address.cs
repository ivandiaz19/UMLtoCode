using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CODE
{
    public abstract class Address
    {
        public string street;
        public string city;
        public string state;
        public string country;
        public int postalCode;
        public abstract bool Validate(string address);
        
    }

    public class Valid : Address
    {
        public override bool Validate(string address)
        {
            return true;
        }
    }
}
