namespace DecodingCSharp1Exam
{
    using System;

    public class Decoding
    {
        private const int FirstDigitASCIICode = 48;
        private const int LastDigitASCIICode = 57;
        private const int FirstUppercaseLetterASCIICode = 65;
        private const int LastUppercaseLetterASCIICode = 90;
        private const int FirstLowercaseLetterASCIICode = 97;
        private const int LastLowercaseLetterASCIICode = 122;

        public static void Main()
        {
            const char StopTheProgramSymbol = '@';
            const int LetterAddingValue = 1000;
            const int DigitAddingValue = 500;
            const int EvenPositionDivider = 100;
            const int OddPositionMultiplier = 100;

            int salt = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            decimal encodedValue = 0;
            int counter = 0;

            foreach (char symbol in inputText)
            {
                if (symbol == StopTheProgramSymbol)
                {
                    break;
                }
                else if (IsLetter(symbol))
                {
                    encodedValue = ((int)symbol * salt) + LetterAddingValue;
                }
                else if (IsDigit(symbol))
                {
                    encodedValue = (int)symbol + salt + DigitAddingValue;
                }
                else
                {
                    encodedValue = (int)symbol - salt;
                }

                if (IsEven(counter))
                {
                    encodedValue /= EvenPositionDivider;
                    Console.WriteLine("{0:F2}", encodedValue);
                }
                else
                {
                    encodedValue *= OddPositionMultiplier;
                    Console.WriteLine(encodedValue);
                }

                counter++;
            }
        }

        public static bool IsLetter(char symbol)
        {
            bool isUppercaseLetter = ((int)symbol >= FirstUppercaseLetterASCIICode) && ((int)symbol <= LastUppercaseLetterASCIICode);
            bool isLowerCaseLetter = ((int)symbol >= FirstLowercaseLetterASCIICode) && ((int)symbol <= LastLowercaseLetterASCIICode);

            return isUppercaseLetter || isLowerCaseLetter;
        }

        public static bool IsDigit(char symbol)
        {
            return ((int)symbol >= FirstDigitASCIICode) && ((int)symbol <= LastDigitASCIICode);
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}