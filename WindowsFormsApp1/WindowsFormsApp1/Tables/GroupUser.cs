using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tables
{
    public class GroupUser
    {
        public uint UserId { get; set; }
        public User User { get; set; }
        public uint GroupId { get; set; }
        public Group Group { get; set; }
    }
}
