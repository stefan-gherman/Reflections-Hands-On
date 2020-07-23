using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceProcess.dll";
            BindingFlags flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;
            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            Console.WriteLine(assembly.FullName);

            var assemblyTypes = assembly.GetTypes();

            foreach(var assemblyType in assemblyTypes)
            {
                Console.WriteLine(assemblyType.Name);

                var typeMemebers = assemblyType.GetMembers(flags);

                foreach(var typeMember in typeMemebers)
                {
                    Console.WriteLine($"Member Type:{typeMember.MemberType}" +
                        $" Member Name: {typeMember.Name}");
                }

            }
        }
    }
}
