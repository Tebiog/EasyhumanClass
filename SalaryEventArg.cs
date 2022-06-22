using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    class SalaryEventArg:EventArgs
    {
        public  string Type { get; set; }                   //зарплата или аванс

        public  float Salary { get; set; }                  //размер денежных выплат
    }
}
