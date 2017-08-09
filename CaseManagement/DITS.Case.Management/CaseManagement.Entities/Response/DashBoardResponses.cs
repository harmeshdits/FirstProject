using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagement.Entities.Response
{
    public class TaskCompleted
    {
        public string Month { get; set; }

        public int? TaskCompletedCount { get; set; }
    }

    public class TaskCompletedListResponse : BaseResponse
    {
        public List<TaskCompleted> TaskCompletedList { get; set; }
    }
}
