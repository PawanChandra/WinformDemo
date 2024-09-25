using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDemo.Models
{
    public static class PermissionManager
    {
        public static List<Permission> GetPermissionList()
        {
            List<Permission> permissionList = new()
            {

            new Permission { Id = Guid.Parse("1e4210fb-c10f-4909-88a0-707c4b0e95f1"), Name = "Add User" },
            new Permission { Id = Guid.Parse("f4c690c9-261a-4e9d-a6cc-5139f467508b"), Name = "Edit User" },
            new Permission { Id = Guid.Parse("49d9c2a4-8f5c-4131-9da4-a7dbf0f852cd"), Name = "Delete User" },

            new Permission { Id = Guid.Parse("d4610673-c6d2-451a-bae4-2ecbf6431543"), Name = "Add New Content" },
            new Permission { Id = Guid.Parse("3a9ec541-e012-4f54-bbcd-462783ab0532"), Name = "Modify Content" },
            new Permission { Id = Guid.Parse("9b541354-9a58-4490-ad39-0d4167af8364"), Name = "Review Content" },
            new Permission { Id = Guid.Parse("cfc80e2a-5cb6-4991-b398-8209791e8036"), Name = "Delete Content" },
            new Permission { Id = Guid.Parse("01f2f8ac-04e2-4ee6-8e17-46417aacae60"), Name = "Approve Content" },
            new Permission { Id = Guid.Parse("bf52f3fc-2a12-4ab1-bbc0-1174cdd658fe"), Name = "Improve Content" },

            new Permission { Id = Guid.Parse("8b25a652-57be-46d1-8ec1-b78b5c50ea59"), Name = "Add New Template" },
            new Permission { Id = Guid.Parse("0559812c-e2df-47bd-aca6-516a1ddf9f9f"), Name = "Modify Template" },
            new Permission { Id = Guid.Parse("6574d676-46e4-404f-b692-e836df60c9cb"), Name = "Review Template" },
            new Permission { Id = Guid.Parse("3972f84e-0a61-4627-a2be-613310bc493b"), Name = "Delete Template" },
            new Permission { Id = Guid.Parse("23d01baf-59fc-449a-be50-880aeae7a537"), Name = "Approve Template" },

            new Permission { Id = Guid.Parse("b01e4304-86ef-4f45-8088-8352bbeeb419"), Name = "Read Others" },
            new Permission { Id = Guid.Parse("48fd39be-437f-4731-afa7-430cabec1e13"), Name = "List Others" }
            };
            return permissionList;
        }
    }
}
