﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.ChatApp
{
    public class Developer : TeamMember
    {
        public Developer(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Developer)}) has received");
            base.Receive(from, message);
        }
    }
}
