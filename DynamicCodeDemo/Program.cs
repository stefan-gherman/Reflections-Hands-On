using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicCodeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll";
            Assembly assembly = Assembly.LoadFile(assemblyPath);
            Type type = assembly.GetType("System.Web.HttpUtility");
            MethodInfo htmlEncode = type.GetMethod("HtmlEncode", new Type[] { typeof(string) });
            MethodInfo htmlDecode = type.GetMethod("HtmlDecode", new Type[] { typeof(string) });
            string encodeThis = @"<h1>Forz#$@!a&Ste**@#@#@$aua<sic> </h1>";
            Console.WriteLine(encodeThis);
            string encodeThisEncoded = (string)htmlEncode.Invoke(null, new object[] { encodeThis });
            Console.WriteLine(encodeThisEncoded);
            string encodeThisDecoded = (string)htmlDecode.Invoke(null, new object[] { encodeThis });
            Console.WriteLine(encodeThisDecoded);
        }
    }
}
