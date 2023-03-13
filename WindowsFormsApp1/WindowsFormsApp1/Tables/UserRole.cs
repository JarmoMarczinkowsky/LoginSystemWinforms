using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tables
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string Role { get; set; }
        
    }
}
