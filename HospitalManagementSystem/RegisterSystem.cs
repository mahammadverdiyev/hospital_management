using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class RegisterSystem
    {
        private DatabaseManager databaseManager;


        public RegisterSystem(DatabaseManager databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        public bool TryRegisterUser(RegisterDetail registerDetail)
        {
            Patient patient = databaseManager.RegisterPatient(registerDetail);

            return false;
        }
    }
}
