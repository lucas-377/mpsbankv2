using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject.Entities
{
    class Holder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Holder() { }
        public Holder(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return 
                "Holder ID: " + Id +
                "\nHolder name: " + Name;
        }
    }
}
