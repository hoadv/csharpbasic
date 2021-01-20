using KMS.CSharpBasic.Core;
using System;

namespace KMS.CSharpBasic.Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            var test1 = cl.ConvertNumberToString(1);
            Console.WriteLine(test1);
        }
    }
}
