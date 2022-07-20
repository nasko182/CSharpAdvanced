﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set { this.name = value; }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set { this.age = value; }
        }


    }
}