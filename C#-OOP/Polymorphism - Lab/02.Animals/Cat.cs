﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"I am {this.Name} and my fovourite food is {this.FavouriteFood} ");
            sb.Append("MEEOW");
            return sb.ToString();
        }
    }
}
