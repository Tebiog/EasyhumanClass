using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP.Calculation
{
    class Calc
    {
        //Делегат - массив указателей на функцию
        public delegate Calc CalcDelegate(Calc a);

        //обобщенный делегат
        public delegate T CalcDelegate<T>(T a, T b);

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public Calc(int num)
        {
            Number = num;
        }
        public Calc DivCalc(Calc a)
        {
            if (a.Number == 0) throw  new DivideByZeroException();
            Console.WriteLine($"{Number} / {a.Number}");
            return new Calc(Number / a.Number);
        }
        public Calc DivCalc(Calc a, Calc b)
        {
            if (b.Number == 0) throw new DivideByZeroException();
            return new Calc(a.Number / b.Number);
        }
        public Calc MultyCalc(Calc a, Calc b)
        {
            return new Calc(a.Number * b.Number);
        }

        public Calc MultyCalc(Calc a)
        {
            Console.WriteLine($"{Number} * {a.Number}");
            return new Calc(Number * a.Number);
        }
        public Calc SubCalc(Calc a, Calc b)
        {
            return new Calc(a.Number - b.Number);
        }
        public Calc SubCalc(Calc a)
        {
            Console.WriteLine($"{Number} - {a.Number}");
            return new Calc(Number - a.Number);
        }
        public Calc AddCalc(Calc a, Calc b)
        {
            return new Calc(a.Number + b.Number);
        }
        public Calc AddCalc(Calc a)
        {
            Console.WriteLine($"{Number} + {a.Number}");
            return new Calc(Number + a.Number);
        }
        public override string ToString()
        {
            return $"Number: {Number}";
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
