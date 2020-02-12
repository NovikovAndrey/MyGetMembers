using System;
using System.Reflection;

namespace GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type myType = Type.GetType("GetType.User", false, true);
            Console.WriteLine("Fields");
            foreach (FieldInfo fieldInfo in myType.GetFields())
            {
                Console.WriteLine($"{fieldInfo.FieldType} {fieldInfo.Name}");
            }
            Console.WriteLine("Properties");
            foreach(PropertyInfo propertyInfo in myType.GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            //Console.WriteLine("Constr");
            //foreach (ConstructorInfo constructorInfo in myType.GetConstructors())
            //{
            //    Console.Write(myType.Name +" (");
            //    ParameterInfo[] parameterInfos = constructorInfo.GetParameters();
            //    for (int i=0; i<parameterInfos.Length; i++)
            //    {
            //        Console.Write(parameterInfos[i].ParameterType.Name + " "+parameterInfos[i].Name);
            //        if (i+1<parameterInfos.Length)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.WriteLine(")");
            //}
            //Console.WriteLine("Methods");
            //foreach(MethodInfo mi in myType.GetMethods())
            //{
            //    string modificator = "";
            //    if (mi.IsStatic)
            //    {
            //        modificator += "static";
            //    }
            //    if (mi.IsVirtual)
            //    {
            //        modificator += "virtual";
            //    }
            //    Console.Write($"{modificator} {mi.ReturnType.Name} {mi.Name} (");
            //    ParameterInfo[] parameterInfos = mi.GetParameters();
            //    for (int i=0; i<parameterInfos.Length; i++)
            //    {
            //        Console.Write($"{parameterInfos[i].ParameterType.Name} {parameterInfos[i].Name}");
            //        if (i+1< parameterInfos.Length)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.WriteLine(")");
            //}
        }
    }
}
