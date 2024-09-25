using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDemo.Models
{
    public static class RoleManager
    {
        public static List<Role> GetRoleList()
        {
            List<Role> roleList=new List<Role>
            {
                new Role{Id=Guid.Parse("ba9ed00e-782d-49b1-b4d3-52667505b097"),Name="Admin"},
                new Role{Id=Guid.Parse("815e973f-1fc6-4fcd-af40-8d5c7642af49"),Name="Content Creator"},
                new Role{Id=Guid.Parse("c8d86f58-977e-4e46-8113-f27f457daab4"),Name="Content Consumer"},
                new Role{Id=Guid.Parse("60667e3c-0fa4-40c5-9b2b-8978cc840b15"),Name="Organization Admin"},
                new Role{Id=Guid.Parse("b63bf4d1-59fd-4f83-8325-faf8307c812d"),Name="Reviewer"},
            };
            return roleList;
        }
    }
}
