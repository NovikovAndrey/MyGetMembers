﻿using System;

namespace Users
{
    public class Class1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Name = {Name}, Age = {Age}");
        }
        public int Payment(int hours, int perHour)
        {
            return hours * perHour;
        }
    }
}
