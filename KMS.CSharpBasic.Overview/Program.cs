using KMS.CSharpBasic.Core;
using System;

namespace KMS.CSharpBasic.Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new Class1();

            string word = cl.ConvertNumberToText(1);
            Console.WriteLine(word);
        }
    }
}
