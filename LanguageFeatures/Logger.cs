using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LanguageFeatures
{
    internal class Logger
    {
        internal static void Log(string variable, Customer customer, [CallerMemberName] string method = null)
        {
            Console.WriteLine($"Error in {method}; variable name {variable}; value : {customer}");
            // throw new NotImplementedException();
        }
    }
}