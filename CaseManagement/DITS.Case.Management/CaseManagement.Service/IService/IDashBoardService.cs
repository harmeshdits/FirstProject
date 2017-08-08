﻿using CaseManagement.Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagement.Service.IService
{
    public interface IDashBoardService
    {
        Task<TaskCompletedResponse> GetTaskCompletedListInMonthsOneYear();
    }
}
