using CaseManagement.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseMangement.Repository.IRepository
{
    public interface IDashBoardRepository
    {
        Task<TaskCompletedListResponse> GetTaskCompletedListInMonthsOneYear();
    }
}
