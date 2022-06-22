using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Channels;
using SimpleOOP.Calculation;
using SimpleOOP.Geomenty;

namespace SimpleOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            //  OOP - 
            // Инкапсуляция - 
            // Полиморфизм  -  перегрузка методов, операторов
            // Наследование - 


            //Human human = new Human();                  //задействуется конструктор без параметров
            //Console.WriteLine(human);
            //Console.WriteLine(human.ToString());
            //Console.WriteLine(human.GetName());
            //Console.WriteLine(human.Name);              //чтения
            //Console.WriteLine(human.BirthDate);         //чтения

            //human.SetName("Max");                       //запись
            //human.Name = "Alex";                        //запись

            //Console.WriteLine(human.Name);
            //Console.WriteLine(human.Gender);
            ////human.Gender = Gender.FEMALE;             //низзя - приватное!


            //Human max = new Human("Max", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25), Gender.MALE, Nationality.Chinise);
            //Console.WriteLine(max);

            //Human julia = new Human() { Name = "Julia", Nationality = Nationality.German };
            //Console.WriteLine(julia);


            //foreach (var value in Enum.GetValues(typeof(EducationLevel)))
            //{
            //    Console.WriteLine($"{(int) value}, {((EducationLevel) value)}");
            //}

            //Employee employee = new Employee();
            //Console.WriteLine(employee);
            //employee.EducationLevel = EducationLevel.Secondary;
            //Console.WriteLine(employee);
            //employee.EducationLevel = EducationLevel.No;


            /*Перегрузка операторов
                Для объявления оператора используйте ключевое слово operator. 
                Объявление оператора должно соответствовать следующим правилам:
                    - Оно должно включать public и модификатор static.
                    - У унарного оператора один входной параметр. 
                    - У бинарного оператора два входных параметра. 
             */


            //sealed class Tutor
            //Tutor tutSpec = new Tutor("Max", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25),
            //    Gender.MALE, Nationality.Chinise, EducationLevel.Higher, 15000f, TutorSpeciality.Astrologer);
            //Console.WriteLine(tutSpec);
            //tutSpec.GetToWork();
            //tutSpec.PayTaxes();
            //tutSpec.PayUtilityBills();
            //Console.WriteLine(tutSpec.Salary);


            //Laborer laborer = new Laborer();
            //Console.WriteLine(laborer);
            //laborer.StartWork("Вынос мусора");

            //Console.WriteLine(laborer);
            //Laborer laborerTwo = laborer;
            //laborerTwo.Name = "Max";

            //Manager manager = new Manager();
            //manager.PushWorker(laborer);
            //manager.PushWorker(new Manager());

            //ListOfWorkers listOfWorkers = new ListOfWorkers();
            //listOfWorkers.AddWorker(laborer);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(manager);
            //listOfWorkers.AddWorker(laborer);
            //Console.WriteLine(listOfWorkers.Count);
            //Console.WriteLine(listOfWorkers);

            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);
            //listOfWorkers.RemoveWorker(1);

            //Console.WriteLine(listOfWorkers);
            ////Console.WriteLine(listOfWorkers[5]);


            /*ICloneable - чтобы обьект смог создавать копию самого себя*/
            //Laborer lab = new Laborer();
            //lab.Name = "Максим";
            //Console.WriteLine(lab);
            //Laborer labCopy = (Laborer)lab.Clone();
            //labCopy.Name = "Сергей";
            //Console.WriteLine(labCopy);

            //Laborer labCompleteCopy = (Laborer)lab.Clone(CloneWorkerMethod.Complete);
            //labCompleteCopy.Name = "Юрий";
            //Console.WriteLine(labCompleteCopy);


            //for (int i = 0; i < listOfWorkers.Count; i++)
            //{
            //    Console.WriteLine(listOfWorkers[i]);
            //}

            /*foreach (var oneWorker in listOfWorkers)
            {
                
            }*/
            //Random random = new Random();
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(0, 10);
            //    Console.Write(arr[i] + " ");
            //}

            //foreach (var val in arr)
            //{
            //    Console.WriteLine(val);
            //}

            ////IEnumerable  возвращает GetEnumerator()
            //    //:MoveNext()
            //    //:Reset() 
            //    //object Current {get;}
            //Console.WriteLine("Using IEnumerator: ");
            //IEnumerator ieArr = arr.GetEnumerator();
            //while (ieArr.MoveNext())
            //{
            //    int item = (int) ieArr.Current;
            //    Console.WriteLine($" - {item}");
            //}

            //Console.WriteLine("Самопис listOfWorkers Enumerator------------------------");
            //Console.WriteLine("Кол сотрудников: " + listOfWorkers.Count);
            //Console.WriteLine();

            //foreach (var oneWorker in listOfWorkers)
            //{
            //    Console.WriteLine(oneWorker);
            //}


            //Tutor tutSpec = new Tutor("Max", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25),
            //    Gender.MALE, Nationality.Chinise, EducationLevel.Higher, 15000f, TutorSpeciality.Astrologer);
            //Laborer max = new Laborer("Sergey", "Penkoff", "vanovith", new DateTime(1980, 5, 13),
            //            Gender.MALE, Nationality.English, EducationLevel.No, 5000f);
            //Manager man = new Manager("Alla", "Dub", "Sergeevna", new DateTime(1956, 4, 7),
            //    Gender.FEMALE, Nationality.British, EducationLevel.Secondary, 9500f);

            //Manager tutSpec = new Manager("Максим", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25),
            //    Gender.MALE, Nationality.Chinise, EducationLevel.Higher, 7000f);
            //Manager max = new Manager("Іван", "Penkoff", "vanovith", new DateTime(1980, 5, 13),
            //    Gender.MALE, Nationality.English, EducationLevel.No, 15000f);
            //Manager man = new Manager("Сергій", "Dub", "Sergeevna", new DateTime(1956, 4, 7),
            //    Gender.FEMALE, Nationality.British, EducationLevel.Secondary, 9500f);

            //ListOfWorkers listOfWorkers = new ListOfWorkers();
            //listOfWorkers.AddWorker(tutSpec);
            //listOfWorkers.AddWorker(max);
            //listOfWorkers.AddWorker(man);
            //Console.WriteLine(listOfWorkers.Count);
            //Console.WriteLine(listOfWorkers);

            //IWorker[] tmp = listOfWorkers.Workers;
            ////dafault - 
            //Array.Sort(tmp);
            //foreach (var work in tmp)
            //{
            //    Console.WriteLine(work);   
            //}

            //Console.WriteLine("Сортировка по зп");
            //Array.Sort(tmp, new ManagerSalaryDescComparer());
            //foreach (var VARIABLE in tmp)
            //{
            //    Console.WriteLine(VARIABLE);
            //}


            //Point2D point2D = new Point2D() {X = 150, Y = 150};

            //object _x = 45.0f;           //boxing
            //float x_ = (float)_x;        //unboxing



            //Point3D<int> point3Dint = new Point3D<int>(15, 150, 35);
            //Console.WriteLine(point3Dint);

            //Point3D<decimal> point3Ddec = new Point3D<decimal>(0.0003m, 0.0007m, 0.0001m);
            //Console.WriteLine(point3Ddec);

            //Pair<string, string> pair = new Pair<string, string>("border", "1px solid red");
            //Console.WriteLine(pair);
            //Console.WriteLine(pair.Key);
            //Console.WriteLine(pair.Value);


            //Pair<int, IWorker> worker= new Pair<int, IWorker>();
            //worker.Key = 1;
            //worker.Value = new Manager(
            //        "Чак",
            //        "Норрис",
            //        "Зигмундович",
            //        new DateTime(1915, 5, 28),
            //        Gender.MALE,
            //        Nationality.English,
            //        EducationLevel.Higher,
            //        45000
            //    );
            //Console.WriteLine(worker);

            //Pair<Guid, IWorker> unWorker = new Pair<Guid, IWorker>();
            //unWorker.Key = Guid.NewGuid();
            //unWorker.Value = new Laborer(
            //        "Вася",
            //        "Пупкин",
            //        "Альбертович",
            //        new DateTime(1995, 3, 8),
            //        Gender.MALE,
            //        Nationality.Chinise,
            //        EducationLevel.No,
            //        6500
            //    );
            //Console.WriteLine(unWorker.Key);
            //Console.WriteLine(unWorker.Value);

            //DrawGraphic.Draw();


            //Делегат - массив указателей на функцию
            //Calc calc = new Calc(15);
            //Calc.CalcDelegate calcDelegate = new Calc.CalcDelegate(calc.MultyCalc);

            //Console.WriteLine(calcDelegate(new Calc(30)));      //15 * 30 = 450

            //calcDelegate += calc.AddCalc;
            //calcDelegate += calc.DivCalc;
            //calcDelegate += calc.SubCalc;

            //Console.WriteLine(calcDelegate(new Calc(10)));
            //Console.WriteLine("Delegate foreach");
            //foreach (Calc.CalcDelegate item in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(calc)); 
            //}


            //Calc.CalcDelegate<Calc> calcDelegateGen = new Calc.CalcDelegate<Calc>(calc.AddCalc);
            //Calc result =  calcDelegateGen(new Calc(35), new Calc(65));


            //Calc.CalcDelegate<double> calcDelegateDouble = new Calc.CalcDelegate<double>(calc.Addition);
            //Console.WriteLine(calcDelegateDouble);

            //calc.Addition(15.0, 45.5);


            /*Tutor tutSpec = new Tutor("Max", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25),
                Gender.MALE, Nationality.Chinise, EducationLevel.Higher, 15000f, TutorSpeciality.Astrologer);
            Console.WriteLine(tutSpec);

            Manager lev = new Manager("Максим", "Ivanoff", "Alexeev", new DateTime(1995, 8, 25),
                Gender.MALE, Nationality.Chinise, EducationLevel.Higher, 7000f);
            Manager max = new Manager("Іван", "Penkoff", "vanovith", new DateTime(1980, 5, 13),
                Gender.MALE, Nationality.English, EducationLevel.No, 15000f);
            Manager man = new Manager("Сергій", "Dub", "Sergeevna", new DateTime(1956, 4, 7),
                Gender.FEMALE, Nationality.British, EducationLevel.Secondary, 9500f);

            Console.WriteLine("Сессия началась....");
            ListOfWorkers groupOfWorkers = new ListOfWorkers();
            groupOfWorkers.AddWorker(lev);
            groupOfWorkers.AddWorker(max);
            groupOfWorkers.AddWorker(man);

            //tutSpec.examenEvent += max.StartExamen;             //подписывается на событие - старта экзамена
            //tutSpec.examenEvent -= max.StartExamen;             //одписывается на событие - старта экзамена


            foreach (Manager student in groupOfWorkers)             //группа студентов подписалась на событие - проведения экзамена наставником
            {
                tutSpec.examenEvent += student.StartExamen;
            }
            
            Console.WriteLine("Tutor инициализирует начало экзамена :)");
            tutSpec.Examen("Сдать на развитие факультета жалкие 350$");     //запуск экзамена


            Console.WriteLine("Сессия закончилась");




            Console.WriteLine("Начало этапа выдачи денежных средств");
            Accountent accountent = new Accountent();

            accountent.salaryEvent += tutSpec.GiveSalary;           //наставник подписался на получение денежных средств


            accountent.TakeSalary(new SalaryEventArg() {Type = "Зарплата", Salary = 15000f});         //начинается выдача денежных средств бухгалтером

            Console.WriteLine("Выдача денежных средств произведена");
            */


            Console.WriteLine();

            Manager max = new Manager("Іван", "Penkoff", "vanovith", new DateTime(1980, 5, 13),
                                        Gender.MALE, Nationality.English, EducationLevel.No, 15000f);

            AllTasksCompany allTasksCompany = new AllTasksCompany();
            allTasksCompany.AddCoordinations(Coordinations.Undefined);
            allTasksCompany.AddCoordinations(Coordinations.Finance);
            allTasksCompany.AddCoordinations(Coordinations.Marketing);
            allTasksCompany.AddCoordinations(Coordinations.Productions);
            allTasksCompany.AddCoordinations(Coordinations.Repair);
            allTasksCompany.AddCoordinations(Coordinations.Security);

            //foreach (var coord in allTasksCompany.Coordinations)
            //{
            //    Console.WriteLine(coord);
            //}
            allTasksCompany.AddTask(new WorkTask()
            {
                DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
                Desc = "Выпить кофейку I раз",
                Coordinations = Coordinations.Marketing
            });
            allTasksCompany.AddTask(new WorkTask()
            {
                DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
                Desc = "Выпить кофейку II раз",
                Coordinations = Coordinations.Marketing
            });
            allTasksCompany.AddTask(new WorkTask()
            {
                DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
                Desc = "Выпить кофейку III раз",
                Coordinations = Coordinations.Marketing
            });
            allTasksCompany.AddTask(new WorkTask()
            {
                DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
                Desc = "Выпить кофейку IV раз",
                Coordinations = Coordinations.Marketing
            });
            allTasksCompany.AddTask(new WorkTask()
            {
                DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
                Desc = "Выпить кофейку V раз",
                Coordinations = Coordinations.Marketing
            });

            //foreach (var task in allTasksCompany.GetTasks(Coordinations.Marketing))
            //{
            //    Console.WriteLine(task);
            //}
            Laborer laborer = new Laborer(
                        "Вася",
                        "Пупкин",
                        "Альбертович",
                        new DateTime(1995, 3, 8),
                        Gender.MALE,
                        Nationality.Chinise,
                        EducationLevel.No,
                        6500
                );
            //менеджер выгружает список задач для выполнения его отделением
            
            max.UploadTasks(allTasksCompany.GetTasks(Coordinations.Marketing));
            
            Console.WriteLine($"Менеджер получил суточные задачи");
            Console.WriteLine($"Количество задач: {max.Tasks.Count}");

            Console.WriteLine("Назначен исполнитель к первой задаче");
            max.AppointExecutor(laborer, max.Tasks[0]);                     //назначаем сотрудника на выполнение задачи

            laborer.TryPerformedTask();                                     //сотрудник приступает к выполнению задачи

            laborer.ReleasedTask();                                         //сотрудник выполнил задачу

            Console.WriteLine($"Задачи, в количестве: {max.Tasks.Count}");






            foreach (var task in allTasksCompany.GetTasks(Coordinations.Marketing))
            {
                if (task.Status == WorkTaskStatus.Released)
                {
                    Console.WriteLine(task);
                }
            }

            //Console.WriteLine("Очередь задач:----------------------------------");
            //Queue<WorkTask> qTasks = new Queue<WorkTask>();

            //qTasks.Enqueue(new WorkTask()
            //{
            //    DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
            //    Desc = "Выпить кофейку I раз",
            //    Coordinations = Coordinations.Marketing
            //});
            //qTasks.Enqueue(new WorkTask()
            //{
            //    DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
            //    Desc = "Выпить кофейку II раз",
            //    Coordinations = Coordinations.Marketing
            //});
            //qTasks.Enqueue(new WorkTask()
            //{
            //    DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
            //    Desc = "Выпить кофейку III раз",
            //    Coordinations = Coordinations.Marketing
            //});
            //qTasks.Enqueue(new WorkTask()
            //{
            //    DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
            //    Desc = "Выпить кофейку IV раз",
            //    Coordinations = Coordinations.Marketing
            //});
            //qTasks.Enqueue(new WorkTask()
            //{
            //    DateOfIssue = new DateTime(2022, 5, 2, 20, 50, 0),
            //    Desc = "Выпить кофейку V раз",
            //    Coordinations = Coordinations.Marketing
            //});

            //foreach (var onQTask in qTasks)
            //{
            //    Console.WriteLine(onQTask);
            //}

            //Console.WriteLine(qTasks.Count);

            //WorkTask t_1 = qTasks.Peek();                   //получение ссылки на первый элемент из очереди

            //Console.WriteLine(qTasks.Count);

            //WorkTask t_2 = qTasks.Dequeue();                //извлечение первого элемента из очереди

            //Console.WriteLine(qTasks.Count);                //




        }
    }
}


