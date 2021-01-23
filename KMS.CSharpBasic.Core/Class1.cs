using Humanizer;
using System;

namespace KMS.CSharpBasic.Core
{
    public class Class1
    {
        public void NumberToWord(int number)
        {
            Console.WriteLine(NumberToWordsExtension.ToWords(number).Pascalize());
        }
    }
}