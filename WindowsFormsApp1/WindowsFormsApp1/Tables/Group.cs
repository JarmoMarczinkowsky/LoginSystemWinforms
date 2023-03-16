using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tables
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
