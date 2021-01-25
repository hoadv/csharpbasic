using System;
using Humanizer;

namespace KMS.CSharpBasic.Core
{
    public class Class1
    {
        public string ConvertNumberToText(int number)
        {
            return number.ToWords();
        }
    }
}
