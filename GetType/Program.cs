using System;
using System.Reflection;

namespace GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type myType = Type.GetType("GetType.User", false, true);
            Console.WriteLine("Methods");
            foreach(MethodInfo mi in myType.GetMethods())
            {
                string modificator = "";
                if (mi.IsStatic)
                {
                    modificator += "static";
                }
                if (mi.IsVirtual)
                {
                    modificator += "virtual";
                }
                Console.Write($"{modificator} {mi.ReturnType.Name} {mi.Name} (");
                ParameterInfo[] parameterInfos = mi.GetParameters();
                for (int i=0; i<parameterInfos.Length; i++)
                {
                    Console.Write($"{parameterInfos[i].ParameterType.Name} {parameterInfos[i].Name}");
                    if (i+1< parameterInfos.Length)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(")");
            }
        }
    }
}
