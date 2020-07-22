using System;
using System.Reflection;

namespace Reflections_Hands_On
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ShowAssembly(Assembly.LoadFile(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.dll"));
            ShowAssembly(Assembly.GetExecutingAssembly());
        }   

        static void ShowAssembly (Assembly assembly)
        {
            Console.WriteLine($"Assembly full name:{assembly.FullName}, " +
                $"Global Assembly Cache {assembly.GlobalAssemblyCache}, " +
                $"Location: {assembly.Location}, " +
                $"Image Runtime Version: {assembly.ImageRuntimeVersion}");

            foreach(var module in assembly.Modules)
            {
                Console.WriteLine($"Current module name: {module.Name}");
            }


        }
    }
}
