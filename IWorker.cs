using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    public interface IWorker: ICloneable               //признак рабочего персонала
    {
        Queue<WorkTask> TQueue { get; }                 //FIFO
        string Work();              //метод - обязательство реализации

        bool IsWorking { get; }     //свойство - обязательство реализации

        void DoTask(object sender, WorkTask e);
    }
}
