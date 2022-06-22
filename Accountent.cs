using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    //бухгалтер
    class Accountent : Employee, IWorker
    {
        public EventHandler<SalaryEventArg> salaryEvent;                //обобщенный делегат
        public bool IsWorking => throw new NotImplementedException();

        public Queue<WorkTask> TQueue { get; }

        public string Work()
        {
            throw new NotImplementedException();
        }

        public override void PayTaxes()
        {
            throw new NotImplementedException();
        }

        public override void PayUtilityBills()
        {
            throw new NotImplementedException();
        }

        internal void TakeSalary(SalaryEventArg salaryEventArg)
        {
            if (salaryEvent != null)
            {
                salaryEvent(this, salaryEventArg);

            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void DoTask(object sender, WorkTask e)
        {
            throw new NotImplementedException();
        }
    }
}
