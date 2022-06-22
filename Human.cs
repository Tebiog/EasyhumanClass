using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{

    abstract class Human
    {
        private string _name;
        private string _surname;
        private string _patronimic;
        private DateTime _birthDate;
        private Gender _gender;
        private Nationality _nationality;

        public string GetName()
        {
            return this._name;
        }
        public void SetName(string name)
        {
            if (name.Length > 1 && name.Length < 25)
            {
                _name = name;
            }
            else
            {
                throw new ArgumentException("Name is not valid");
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this.SetName(value);
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            private set
            {
                if (value <= DateTime.Now && value > DateTime.Now.AddYears(-125))
                {
                    _birthDate = value;
                } else
                {
                    throw new ArgumentException("Birth Date incorrect value");
                }
            }
        }

        public Gender Gender {
            get { return _gender; }
            private set {
                _gender = value;
            } 
        }
        public Nationality Nationality { 
            get { return _nationality; }
            set {
                _nationality = value;
            } 
        }
        public string Surname { get; set; }
        public string Patrinimic { get; set; }

        public Human()
        {
            Name = "no-name";
            Surname = "no-surname";
            Patrinimic = "no-patronimic";
            BirthDate = DateTime.Now;
            Gender = default;
            Nationality = default;
        }
        public Human(string name, string surname, string patronimic, DateTime birthDate, Gender gender, Nationality nationality)
        {
            Name = name;
            Surname = surname;
            Patrinimic = patronimic;
            BirthDate = birthDate;
            Gender = gender;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Human: \n\t" +
                $"Name: {Name};\n\t" +
                $"Surname: {Surname};\n\t" +
                $"Patronimic: {Patrinimic};\n\t" +
                $"Gender: {Gender};\n\t" +
                $"Nationality: {Nationality};\n\t" +
                $"Birth Date: {BirthDate.ToShortDateString()}";
        }

        public virtual void GetToWork()
        {
            Console.WriteLine("Public transport moving");
        }


    }
}
