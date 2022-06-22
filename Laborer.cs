using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    //низкоквалифицированный сотрудник

    /*
     * унаследоваться от одного класса
     *  реализовать интерфейс (более одного)
     */
    class Laborer : Employee, IWorker, ICloneable
    {
        private Queue<WorkTask> _tasks = new Queue<WorkTask>();
        private bool _isWorking; //поле
        private string _workDescription;
        public string WorkDescription
        {
            get { return _workDescription; }
        }

        public bool IsWorking //свойство реализованное от интерфейса
        {
            get { return _isWorking; }
        }

        public Queue<WorkTask> TQueue { get; }

        public string Work()
        {
            return _workDescription;
        }

        public void StopWork()
        {
            _isWorking = false;
        }

        public void StartWork(string desc)
        {
            _isWorking = true;
            _workDescription = desc;
        }

        public override void PayTaxes()
        {
            throw new NotImplementedException();
        }

        public override void PayUtilityBills()
        {
            throw new NotImplementedException();
        }

        public Laborer()
        {
            _isWorking = false;
            _workDescription = "Ведутся работы по организации самой работы";
        }

        public Laborer(string name, string surname, string patronimic, DateTime birthDate, Gender gender, Nationality nationality,
            EducationLevel educationLevel, float salary):base(name, surname, patronimic, birthDate, gender, nationality, educationLevel, salary)
        {
            _isWorking = false;
            _workDescription = "Ведутся работы по организации самой работы";
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Status Working: {IsWorking}; \n\t" +
                   $"Current Work: {WorkDescription}; \n\t";
        }

        public object Clone()
        {
            //поверхносное кипирование - юзать только при простых типах (нету ссылочных)
            //глубокое полное копирование - ручной перебор всех полей

            return this.MemberwiseClone();              //авто создание поверхносной копии
        }

        public object Clone(CloneWorkerMethod method)
        {
            switch (method)
            {
                case CloneWorkerMethod.Superficial:
                {
                    return Clone();
                }
                case CloneWorkerMethod.Complete:
                {
                    return new Laborer (
                        this.Name, 
                        this.Surname,
                        this.Patrinimic,
                        this.BirthDate,
                        this.Gender,
                        this.Nationality,
                        this.EducationLevel,
                        this.Salary
                        );
                }
            }
            throw new ArgumentException("CloneWorkerMethod incorrect");
        }

        public void DoTask(object sender, WorkTask e)
        {
            _tasks.Enqueue(e);
            ReleaseTaskEventHandler += ((IManager)sender).CheckTaskStatus;
        }

        

        public void TryPerformedTask()                              //попытка выполнить задачу
        {
            _tasks.Peek().Status = WorkTaskStatus.Performed;
            Console.WriteLine("Task performed.....");
        }

        public EventHandler<WorkTask> ReleaseTaskEventHandler;      //для обратной связи с руководителем    
        public void ReleasedTask()                                  //закрываем задачу - выполнили
        {
            if (ReleaseTaskEventHandler != null)
            {
                WorkTask task = _tasks.Dequeue();
                task.Status = WorkTaskStatus.Released;
                task.DateOfRelised  = DateTime.Now;
                ReleaseTaskEventHandler(this, task);
            }
        }
    }
}
