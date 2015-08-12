namespace EnigmaCatCSharp2Exam
{
    using System;
    using System.Text;

    public class EnigmaCat
    {
        public static void Main()
        {
            var wordsInCatLanguage = Console.ReadLine().Split(' ');

            foreach (var word in wordsInCatLanguage)
            {
                ulong resultInCatLanguage = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    resultInCatLanguage *= 17;
                    resultInCatLanguage += (ulong)(word[i] - 'a');
                }

                var resultInEnglish = new StringBuilder();

                while (resultInCatLanguage > 0)
                {
                    resultInEnglish.Insert(0, (char)((resultInCatLanguage % 26) + 'a'));
                    resultInCatLanguage /= 26;
                }

                Console.Write(resultInEnglish.ToString() + " ");
            }

            Console.WriteLine();
        }
    }
}
