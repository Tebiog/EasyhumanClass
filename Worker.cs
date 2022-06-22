using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    abstract class Worker : Employee, IWorker
    {

        private bool _isWorking; //поле
        private string _workDescription;
        public bool IsWorking { get { return _isWorking; } }
        public string WorkDescription { get { return _workDescription; } }
        public Worker()
        {
            _isWorking = false;
        }
        public Worker(string name, string surname, string patronimic, DateTime birthDate, Gender gender, Nationality nationality, EducationLevel educationLevel, float salary) : base(name, surname, patronimic, birthDate, gender, nationality, educationLevel, salary)
        {
            _isWorking = false;
        }
        public void StopWork()
        {
            _isWorking = false;
        }

        public void StartWork(string desc)
        {
            _isWorking = true;
        }
        public virtual void SetWorkDesc(string workDesc)
        {
            workDesc = default(string);
            _workDescription = workDesc;
        }
        public string Work()
        {
            throw new NotImplementedException();
        }
    }
}
