using CleanTblHrEmp.Application.OtherServices.Inferface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTblHrEmp.Application.OtherServices.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime now => DateTime.Now;
    }
}
