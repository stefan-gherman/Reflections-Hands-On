using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyAttrDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type typeStuff = typeof(AssemblyDescriptionAttribute);
            object[] result = assembly.GetCustomAttributes(typeStuff, false);

            if(result.Length > 0)
            {
                AssemblyDescriptionAttribute desc = (AssemblyDescriptionAttribute)result[0];
                Console.WriteLine("Description is: {0}", desc.Description);
            }
        }
    }
}
