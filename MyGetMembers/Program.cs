using System;
using System.Reflection;

namespace MyGetMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("MyGetMembers.User", false, true);
            foreach(MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            Console.ReadKey();
        }

    }
}
