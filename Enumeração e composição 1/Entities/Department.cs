using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeração_e_composição_1.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
