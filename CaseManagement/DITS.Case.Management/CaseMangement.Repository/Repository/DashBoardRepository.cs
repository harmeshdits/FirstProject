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
        TaskCompletedListResponse taskCompletedResponse;

        #endregion

        #region public

        public async Task<TaskCompletedListResponse> GetTaskCompletedListInMonthsOneYear()
        {
            try
            {
                taskCompletedResponse = new  TaskCompletedListResponse();
                using (db = new CaseManagementEntities())
                {
                    //SqlParameter PatientType = new SqlParameter("@PatientType", SqlDbType.Int);
                    //PatientType.Direction = ParameterDirection.Input;
                    //PatientType.Value = patientType;
                    //response.PatientDashBoard = dbo.Database.SqlQuery<PatientDashBoardGridViewList>("dbo.GetPatientListing @PatientType", PatientType).ToList();
                    taskCompletedResponse.TaskCompletedList = await db.Database.SqlQuery<TaskCompleted>("dbo.sp_GetTaskCompletedByMonth").ToListAsync();
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