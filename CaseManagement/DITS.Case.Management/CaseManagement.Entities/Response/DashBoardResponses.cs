using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagement.Entities.Response
{
    public class TaskCompletedResponse : BaseResponse
    {
        public string Month { get; set; }

        public int TaskCompletedCount { get; set; }
    }
}
