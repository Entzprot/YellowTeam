using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageManagement;

namespace TeamCRUD
{
    class TeamManagement
    {
        TeamSaver _teamSaver;
   
        public TeamManagement()
        {
            _teamSaver = new TeamSaver();
        }

        public TeamManagement(TeamSaver teamSaver)
        {
            _teamSaver = teamSaver;
        }

        public void CreateTeam()
        {
            throw new NotImplementedException();
        }
       
        public void AddUserToTeam()
        {
            throw new NotImplementedException();
        }

        public void RemoveUserFromTeam()
        {
            throw new NotImplementedException();
        }

        public void UpdateTeam()
        {
            throw new NotImplementedException();
        }
     
        public void RetrieveTeam()
        {
            throw new NotImplementedException();
        }

        public void DeleteTeam()
        {
            throw new NotImplementedException();
        }
            
    }
}
