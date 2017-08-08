using CaseMangement.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseMangement.Repository.Context;
using CaseManagement.Entities.Response;
using System.Data.Entity;

namespace CaseMangement.Repository.Repository
{
    public class DashBoardRepository: IDashBoardRepository
    {
        #region private 

        private CaseManagementEntities db;

        // Response class object
        TaskCompletedResponse taskCompletedResponse;

        #endregion

        #region public

        public async Task<TaskCompletedResponse> GetTaskCompletedListInMonthsOneYear()
        {
            try
            {
                taskCompletedResponse = new  TaskCompletedResponse();
                using (db = new CaseManagementEntities())
                {
                    taskCompletedResponse.Month = "month";
                    taskCompletedResponse.TaskCompletedCount = 1;
                   await db.Tasks.FirstOrDefaultAsync();
                }
            }
            catch (Exception ex)
            {
                taskCompletedResponse.AddError(ex.Message);
            }
            return taskCompletedResponse;

        }

        #endregion


    }
}
