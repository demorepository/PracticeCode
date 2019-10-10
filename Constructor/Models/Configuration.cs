using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseApp.Constructor.Models
    {
    public class Configuration
        {
        
        public static string ReturnAddress ( )
            {
            return Address.Url;
            }

        public string ReturnAddress2 ( )
            {
            Address address = new Address();
            return address.Url2;
            }

        public string ModifyUrlAndReturnNew (string newUrl )
            {
            Address address = new Address(newUrl);

            return address.Url2;

            
            }
        }
    }
