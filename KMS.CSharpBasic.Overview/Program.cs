using System;
using KMS.CSharpBasic.Core;

namespace KMS.CSharpBasic.Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new Class1();
            var word = cl.ConvertNumberToText(1);
            Console.WriteLine("This is number " + word);
        }
    }
}
