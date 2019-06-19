using System;

using PhoneticEncoderLibrary;

namespace PhoneticAlphabetEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneticEncoder = new PhoneticEncoder();

            var plainText = "This is a secret message.";

            var encodedText = phoneticEncoder.Encode(plainText);

            Console.WriteLine(plainText);
            Console.WriteLine(encodedText);


            var roundtripText = phoneticEncoder.Decode(encodedText);


            Console.WriteLine("Try it for yourself");
            Console.WriteLine("**************************");

            var inputText =  Console.ReadLine();
            var encodedInputText = phoneticEncoder.Encode(inputText);

            Console.WriteLine(encodedInputText);
            Console.WriteLine("And decoded");
            Console.WriteLine(phoneticEncoder.Decode(encodedInputText));


            Console.WriteLine("**************************");

            Console.ReadLine();
            

        }
    }
}
