using ExerciseApp.Constructor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseApp
    {
    public class Program
        {
        public static void Main ( string[] args )
            {

            //Configuration configuration = new Configuration();
            Console.WriteLine(Configuration.ReturnAddress());
            Configuration configuration = new Configuration();
            Console.WriteLine(configuration.ReturnAddress2());
            Console.WriteLine(configuration.ModifyUrlAndReturnNew("https:google.pl")); 
            Console.WriteLine(configuration.ModifyUrlAndReturnNew("https://wp.pl")); 



            }
        }
    }
