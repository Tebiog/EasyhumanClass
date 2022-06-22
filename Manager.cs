using System;
using System.Collections.Generic;

namespace SimpleOOP
{
    class Manager : Employee, IManager, IWorker, IComparable     //множественная реализация интерфейсов
    {
        private List<WorkTask> _tasks = new List<WorkTask>();
        public ListOfWorkers Workers => throw new NotImplementedException();
        public List<WorkTask> Tasks
        {
            get { return _tasks; }
        }
        public Queue<WorkTask> TQueue { get; }

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

        public void DoTask(object sender, WorkTask e)
        {
            throw new NotImplementedException();
        }

        public Manager()
        {
            _isWorking = false;
            _workDescription = "Организационно подготоврительные работы начаты";
            
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

        public void PushWorker(IWorker worker)
        {

        }
        public IWorker GetWorker(int index)
        {
            throw new NotImplementedException();
        }
        public IWorker GetWorker(string workDesc)
        {
            throw new NotImplementedException();
        }
        public Manager(string name, string surname, string patronimic, DateTime birthDate, Gender gender, Nationality nationality,
            EducationLevel educationLevel, float salary) : base(name, surname, patronimic, birthDate, gender, nationality, educationLevel, salary)
        {
            _isWorking = false;
            _workDescription = "Организационно подготоврительные работы начаты";
        }
        public void Control()
        {
            Console.WriteLine("Manager controlled all workers");
        }
        public void Organize()
        {
            Console.WriteLine("Manager organized the work successfully");
        }
        public override void PayTaxes()
        {
            Console.WriteLine("Manager all taxes payed");
        }
        public override void PayUtilityBills()
        {
            Console.WriteLine("Manager all utility bills payed");
        }
        public string Work()
        {
            return WorkDescription;
        }
        public int CompareTo(object obj)
        {
            //дефолтная сортировка - сортировка по имени (возрастание)
            Manager tmp = (Manager) obj;
            if (tmp != null)
            {
                return this.Name.CompareTo(tmp.Name);           //стандартный стринговый компарер
            }
            else
            {
                throw new Exception("Incorrect compare two values");
            }
        }

        public void StartExamen(string task)
        {
            Console.WriteLine($"Я {Name}, получил задачу на экзамен:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\t {task}");
            Console.ResetColor();;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public void UploadTasks(List<WorkTask> tasks)
        {
            foreach (var oneTask in tasks)
            {
                _tasks.Add(oneTask);
            }                                
        }

        public EventHandler<WorkTask> OutTaskEventHandler;
        public void AppointExecutor(IWorker worker, WorkTask task)
        {
            OutTaskEventHandler += worker.DoTask;
            
            task.Worker = worker;
            task.Status = WorkTaskStatus.Appointed;
            OutTaskEventHandler(this, task);
        }

        public void CheckTaskStatus(object sender, WorkTask e)
        {
            Console.WriteLine($"Сообщение от исполнителя {((Employee)sender).Name}: ");
            Console.WriteLine($"Задача: {e.GuidId}; Status: {e.Status}; Date of relised: {e.DateOfRelised}");
            
            //пересчитать задачи - синхронизировать с писком задач компании
        }
    }
}
