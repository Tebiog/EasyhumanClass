using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    interface IManager:IWorker
    {
        void Control();                             //контроль рабочих процессов

        void Organize();                            //организация рабочих процессов

        ListOfWorkers Workers { get; }              //доступ к прямым подчиненным

        List<WorkTask> Tasks { get; }               //список задач на выполнение

        void CheckTaskStatus(object sender, WorkTask e);
    }
}
