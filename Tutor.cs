using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{


    //массив указателей на метод который принимает строковое описание задачи экзамена
    public delegate void ExamenDelegate(string task);

    sealed class Tutor: Employee, IWorker            //запечатанный класс - запрещаем наследование от этого класа
    {
        public TutorSpeciality TutorSpeciality { get; set; } = TutorSpeciality.None;

        public event ExamenDelegate examenEvent;    //событие типа проведения экзамена

        public void Examen(string pushTask) //триггер - механизм который запустит проведение экзамена
        {
            if (examenEvent != null)
            {
                examenEvent(pushTask);
            }
        }

        public Tutor():base()
        {
                
        }

        public Tutor(string name, string surname, string patronimic, DateTime birthDate, Gender gender, Nationality nationality,
                        EducationLevel educationLevel, float salary, TutorSpeciality speciality)
            :base(name, surname, patronimic, birthDate, gender, nationality, educationLevel, salary)
        {
            TutorSpeciality = speciality;
        }

        public override void PayTaxes()
        {
            Console.WriteLine("Tutor all taxes payed");
        }

        public override void PayUtilityBills()
        {
            Console.WriteLine("Tutor all utility bills payed");
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Tutor Speciality: {TutorSpeciality}; \n\t";
        }
        public override void GetToWork()                                //public new void GetToWork() - синтаксический сахар 
        {
            Console.WriteLine("Car moving");
        }


        public Queue<WorkTask> TQueue { get; }

        public string Work()
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool IsWorking { get; }
        public void DoTask(object sender, WorkTask e)
        {
            throw new NotImplementedException();
        }
    }

    //низзя унаследоваться от класса Tutor
    //class  TestTutor: Tutor
    //{

    //}
}
