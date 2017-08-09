using CaseManagement.Entities.Response;
using CaseManagement.Service.IService;
using CaseMangement.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagement.Service.Service
{
    public class DashBoardService : IDashBoardService
    {
        #region private

        private IDashBoardRepository _IDashBoardRepository;

        #endregion

        #region Constructor

        public DashBoardService(IDashBoardRepository IDashBoardRepository)
        {
            _IDashBoardRepository = IDashBoardRepository;
        }

        #endregion

        #region public
        public async Task<TaskCompletedListResponse> GetTaskCompletedListInMonthsOneYear()
        {   
            return await _IDashBoardRepository.GetTaskCompletedListInMonthsOneYear();
        }

        #endregion

    }
}
