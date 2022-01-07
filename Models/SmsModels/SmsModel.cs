using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib.SmsModels
{
    public class SmsModel
    {
        public string PhoneNumber { get; set; }

        public string Message { get; set; }

        public DateTime? SendTime { get; set; }

    }
}
