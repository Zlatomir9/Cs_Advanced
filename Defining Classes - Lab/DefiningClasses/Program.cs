﻿using _01.DefiningClasses;
using DefiningClasses;
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            foreach (var member in family.GetOlderThan30())
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
