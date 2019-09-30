using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseApp.Methods
    {
    public class Lesson1
        {

        List<string> listOfStrings = new List<string>();

        public int?[] arrayNumbers = new int?[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public int?[] returnArrayNumbers ( )
            {
            return arrayNumbers;
            }

        public bool CheckIfNumOnTheList (int num )
            {
            bool result = false;

            foreach ( var item in arrayNumbers )
                {
                if ( item == num )
                    {
                    result = true;
                    break;
                    }
                }
            return result;
            }

        public bool CheckIfNumOnTheListViaLinq ( int num)
            {

            return arrayNumbers.Where(x => x == num).FirstOrDefault() != null;
            
            }

        public void AddStringsToTheList (string item )
            {
            listOfStrings.Add(item);
            }

        public string ReturnItemFromTheList (string value )
            {

            return listOfStrings.Where(x => x == value).FirstOrDefault();

            }

        public int?[] ChangeNumPositionInArray ( )
            {

            int? firstNum = arrayNumbers[0];
            arrayNumbers[0] = arrayNumbers[arrayNumbers.Length - 1];//Length counts list elements from 1 not according to index
            arrayNumbers[arrayNumbers.Length - 1] = firstNum;
            return arrayNumbers;

            }

        }
    }
