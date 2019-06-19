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

            Console.ReadLine();

        }
    }
}
