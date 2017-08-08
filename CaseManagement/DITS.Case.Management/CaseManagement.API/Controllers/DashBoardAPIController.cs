using CaseManagement.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public string test()
        {
            return _IDashBoardService.test();
        }

        #endregion

    }
}
