using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageManagement;

namespace TeamCRUD
{
    class UserManagement
    {
        TeamSaver _teamSaver;

        public UserManagement()
        {
            _teamSaver = new TeamSaver();
        }

        public UserManagement(TeamSaver teamSaver)
        {
            _teamSaver = teamSaver;
        }

        public void CreateUser()
        {
            throw new NotImplementedException();
        }  

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

        public void RetrieveUser()
        {
            throw new NotImplementedException();
        }


        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

    }
}
