using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseApp.Constructor.Models
    {
    public class Address
        {
        public static string Url { get; set; }
        public string Url2 { get; set; }



        public Address ( )
            {
            Url2 = HelperInit.ReturnUrl();

            }

        static Address ( )
            {
            Url = HelperInit.ReturnUrl();
            }

        public Address(string newUrl )
            {
            Url2 = newUrl;
            }
        }
    }
