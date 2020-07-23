using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace DemoDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyName assemblyName = new AssemblyName("This is a name");
            assemblyName.Version = new Version("1.0.0");
            AppDomain currentDomain = AppDomain.CurrentDomain;
            AssemblyBuilder builder = currentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.ReflectionOnly);
            ModuleBuilder module = builder.DefineDynamicModule("CodeModule", "DemoAssembly.dll");
            TypeBuilder typeBuilder = module.DefineType("Horse");

            Type currentType = typeBuilder.CreateType();
            Console.WriteLine(currentType.FullName);

            foreach(var info in currentType.GetMembers())
            {
                Console.WriteLine($"Member type: {info.MemberType}, name: {info.Name}");
            }
        }
    }
}
