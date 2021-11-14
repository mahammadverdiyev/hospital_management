using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class DatabaseManager
    {
        private HospitalManSystemContext context;

        public DatabaseManager(HospitalManSystemContext context)
        {
            this.context = context;
        }

        public User TryFindUser(LoginDetail loginDetail)
        {
            var targetUser = context.Users.FirstOrDefault(user => user.Email == loginDetail.Email);

            return targetUser;
        }
    }
}
