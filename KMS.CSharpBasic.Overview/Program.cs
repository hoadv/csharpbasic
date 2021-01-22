using KMS.CSharpBasic.Core;
using System;

namespace KMS.CSharpBasic.Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Class1();
            var word = c1.ConvertNumberToText(1);
            Console.WriteLine(word);
        }
    }
}
