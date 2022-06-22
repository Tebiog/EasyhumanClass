using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    //невозможность создать экземпляр класса
    //абстрактный метод
    abstract class Employee : Human
    {
        private float _salary;
        private EducationLevel _educationLevel;
        private int _workExperience;                        //в месяцах
        public Coordinations Coordinations { get; set; }

        //абстрактные методы - не содержат реализации - они требование для производного класса обязательно реализовать их
        public abstract void PayTaxes();
        public abstract void PayUtilityBills();

        public float Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0.0f && value < float.MaxValue)
                {
                    _salary = value;
                } else
                {
                    throw new ArgumentException("Salary level incorrect");
                }
            }
        }
        public int WorkExp
        {
            get { return _workExperience; }
        }
        public void AddWorkExperiance(int newExpMonth)
        {
            if (newExpMonth < 0) throw new ArgumentException();
            _workExperience += newExpMonth;                             //добавим нужное количество отработанных месяцев
        }
        public void AddWorkExperiance(float newExpYear)
        {
            // HW
        }

        //?
        public EducationLevel EducationLevel    
        {
            get { return _educationLevel;  }    
            set
            {
                if(value >= _educationLevel)
                {
                    _educationLevel = value;
                }
                else
                {
                    throw new ArgumentException("education error");
                }
            }
        }
        public Employee() : base()
        {
            _educationLevel = default;
            Salary = default;
        }
        public Employee(string name, string surname, string patronimic, DateTime birthDate, 
                            Gender gender, Nationality nationality, EducationLevel educationLevel, float salary): base(name, surname, patronimic, birthDate, gender, nationality)
        {
            EducationLevel = educationLevel;
            Salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\n\tEducation Level: {EducationLevel}; \n\t" +
                $"Salary: {Salary}; \n\t";
        }

        public void GiveSalary(Object sender, SalaryEventArg arg)
        {
            Employee employee = (Employee)sender;
            Console.WriteLine($"Специалист: {employee.Name}, инитит выдачу денежных средств");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Я {Name}, получил {arg.Type}, в размере: {arg.Salary};");
            Console.ResetColor();;
        }
    }
}
