using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Generator
    {
        public List<Char> CharList { get; set; }
        private List<Char> SelectedChar { get; set; }

        private Random _random;

        //Constructor method of Generator class
        public Generator() 
        {
            CharList = new List<Char>();
            _random = new Random();
            SelectedChar = new List<Char>();
        }

        //This method is called with every user selection
        public List<Char> AddList(string isStatus, string isType)
        {
            //If user is selection is yes
            if (isStatus == "y" || isStatus == "Y")
            {
                //Related character string convert to a character list
                foreach (var x in isType)
                {  
                    Char character = new Char()
                    {
                        character = x
                    };
                    CharList.Add(character);
                }
            }
            else
            {
                Console.WriteLine("Password can not produced because you sayed no all question.");
            }
            return CharList;
        }

        //Get size of the character list
        public int CharCount => CharList.Count();

        //Generate random characters from char list
        public char RandomChar()
        {
            var randomIndex = _random.Next(0, CharCount); 
            var RandomChar = CharList[randomIndex];
            return RandomChar.character;
        }

        //Generate a password string from random characters whose size is selection for users password length
        public string RandomPassword(int isPasswordLength)
        {
            var password = "";
            for (int i = 0; i < isPasswordLength; i++)
            {
                password += Convert.ToString(RandomChar());
            }
            return password;
        }






    }
}
