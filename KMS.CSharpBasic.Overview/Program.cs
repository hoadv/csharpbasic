using KMS.CSharpBasic.Core;
using System;

namespace KMS.CSharpBasic.Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            var cla = new Class1();
            var word = cla.ConvertNumberToText(1);
            Console.WriteLine("This is number " + word);
            Console.WriteLine("Hello World!");
        }
    }
}
