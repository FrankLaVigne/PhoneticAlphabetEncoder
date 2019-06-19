using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Text;

namespace PhoneticEncoderLibrary
{
    public class PhoneticEncoder
    {
        private Dictionary<char, string> alphabet;


        public PhoneticEncoder()
        {
            InitializeDictionary();
        }


        public string Encode(string inputString)
        {
            StringBuilder outputString = new StringBuilder();

            foreach (var character in inputString.ToUpper().ToCharArray())
            {
                try
                {
                    outputString.Append(this.alphabet[character]);
                }
                catch (Exception)
                {
                    outputString.Append(character);
                }
                outputString.Append(" ");
            }
            return outputString.ToString();
        }

        public string Decode(string inputString)
        {
            StringBuilder outputString = new StringBuilder();

            var inputStringArray = inputString.Split(' ');


            foreach (var word in inputStringArray)
            {
                try
                {
                    outputString.Append(word.ToCharArray()[0]);
                }
                catch (Exception)
                {
                    outputString.Append(" ");
                }
            }
            return outputString.ToString();
        }

        private void InitializeDictionary()
        {
            this.alphabet = new Dictionary<char, string>();

            this.alphabet.Add('A', "Alfa");
            this.alphabet.Add('B', "Bravo");
            this.alphabet.Add('C', "Charlie");
            this.alphabet.Add('D', "Delta");
            this.alphabet.Add('E', "Echo");
            this.alphabet.Add('F', "Foxtrot");
            this.alphabet.Add('G', "Golf");
            this.alphabet.Add('H', "Hotel");
            this.alphabet.Add('I', "India");
            this.alphabet.Add('J', "Juliett");
            this.alphabet.Add('K', "Kilo");
            this.alphabet.Add('L', "Lima");
            this.alphabet.Add('M', "Mike");
            this.alphabet.Add('N', "November");
            this.alphabet.Add('O', "Oscar");
            this.alphabet.Add('P', "Papa");
            this.alphabet.Add('Q', "Quebec");
            this.alphabet.Add('R', "Romeo");
            this.alphabet.Add('S', "Sierra");
            this.alphabet.Add('T', "Tango");
            this.alphabet.Add('U', "Uniform");
            this.alphabet.Add('V', "Victor");
            this.alphabet.Add('W', "Whiskey");
            this.alphabet.Add('X', "X-ray");
            this.alphabet.Add('Y', "Yankee");
            this.alphabet.Add('Z', "Zulu");

        }
    }
}
