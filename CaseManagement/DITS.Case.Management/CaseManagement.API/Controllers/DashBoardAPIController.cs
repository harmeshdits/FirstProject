using CaseManagement.Entities.Response;
using CaseManagement.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CaseManagement.API.Controllers
{
    public class DashBoardAPIController : ApiController
    {

        #region private

        private IDashBoardService _IDashBoardService;

        #endregion

        #region Constructor

        public DashBoardAPIController(IDashBoardService IDashBoardService)
        {
            _IDashBoardService = IDashBoardService;
        }

        #endregion

        #region public
        [HttpGet]
        public async Task<IHttpActionResult> GetTaskCompletedListInMonthsOneYear()
        {
            var taskCompletedListInMonthsOneYearDetail = await _IDashBoardService.GetTaskCompletedListInMonthsOneYear();

            if (taskCompletedListInMonthsOneYearDetail.Success)
            {
                return Ok(taskCompletedListInMonthsOneYearDetail);
            }
            return BadRequest(taskCompletedListInMonthsOneYearDetail.Errors.FirstOrDefault());
        }

        #endregion

    }
}
