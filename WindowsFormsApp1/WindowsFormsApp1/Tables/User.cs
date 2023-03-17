using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tables
{
    public class User
    {
        public uint UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; } = null;
        public int RoleId { get; set; }
        public Role Role { get; set; } = null;
        public ICollection<GroupUser> GroupUsers { get; set; } = new List<GroupUser>();

    }
}
