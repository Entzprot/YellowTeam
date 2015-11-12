using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientFacade
{
    class ClientAdaptor
    {

        public void GetStudies(int userID)
        {
            //retrieves all the studyIDs a user belongs to.
            throw new NotImplementedException();
        }

        public void GetTasks(int studyID, int userID, int count, String type)
        {
            //retrieves a certain amount of tasks which need to be performed by the specified user for the specified study.Tasks are returned in the order in which they are recommended to be performed.
            throw new NotImplementedException();
        }

        public void GetStudyOverview(int studyID)
        {
            //reports the different stages in the study, and per stage, for each user the amount of tasks done, out of all the known tasks to be done
            throw new NotImplementedException();
        }

        public void DeliverTask(int studyID, int userID, int taskID, IList<Object> modifiedFields)
        {
            //deliver a finished task, including the resulting modified fields. This should return whether or not the task was delivered (e.g., can still be delivered) successfully.This can be called several times for the same task, in which
            //case the latest value is used (if the task is still editable, which is decided by the server).
            throw new NotImplementedException();
        }

        public void GetResource(int id)
        {
            //retrieves a specified resource (e.g., PDF file).
            throw new NotImplementedException();
        }

        public void GetReviewableTaskIDs(int userID, int studyID)
        {
            //retrieves all task IDs of tasks which have already been delivered, and can still be edited.This can be used to clear the cache of tasks which can still be edited within the client.
            throw new NotImplementedException();
        }

        public void GetReviewableTasks(int userID, int studyID)
        {
            //retrieves all tasks which have already been delivered, and can still be edited.This allows editing already delivered tasks.
            throw new NotImplementedException();
        }
    }
}
