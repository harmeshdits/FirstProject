using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagement.Entities.Response
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Errors = new List<string>();
        }

        public Boolean Success { get { return !Errors.Any(); } }

        public List<string> Errors { get; set; }

        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}
