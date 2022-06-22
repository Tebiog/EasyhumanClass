using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    public class WorkTask:EventArgs, ICloneable
    {
        public Guid GuidId { get; set; }
        public string Desc { get; set; }
        public WorkTaskStatus Status { get; set; }
        public IWorker Worker { get; set; }
        public DateTime? DateOfRelised { get; set; }
        public DateTime DateOfIssue { get; set; }

        public Coordinations Coordinations { get; set; }

        public WorkTask()
        {
            GuidId = Guid.NewGuid();
            DateOfIssue = DateTime.Now;
            Status = WorkTaskStatus.Created;
            DateOfRelised = null;
        }

        public WorkTask(string desc, IWorker worker, DateTime dateOfIssue)
        {
            GuidId = Guid.NewGuid();
            Status = WorkTaskStatus.Created;
            Desc = desc;
            Worker = worker;
            DateOfIssue = dateOfIssue;
            DateOfRelised = null;
        }

        public override string ToString()
        {
            return
                $"Task ID: {GuidId};\nDate of Issue: {DateOfIssue};\nStatus: {Status};\nDesc: {Desc};\nDate of Released: {DateOfRelised};\nWorker: {Worker}. ";
        }

        public object Clone()
        {
            WorkTask copyTask = (WorkTask)this.MemberwiseClone();

            if (this.Worker != null)
            {
                copyTask.Worker = (IWorker)this.Worker.Clone();
            }

            return copyTask;
        }
    }
}
