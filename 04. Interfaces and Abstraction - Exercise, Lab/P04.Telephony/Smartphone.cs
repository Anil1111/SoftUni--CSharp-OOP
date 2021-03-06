﻿namespace P04.Telephony
{
    using P04.Telephony.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Smartphone : ICalling, IBrowsing
    {
        public string Browsing(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Calling(string number)
        {
            if (!number.Any(char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }
    }
}
