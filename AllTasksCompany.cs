using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleOOP
{
    class AllTasksCompany
    {
        private Dictionary<Coordinations, List<WorkTask>> _allTasks;

        public IEnumerable<Coordinations> Coordinations
        {
            get { return _allTasks.Keys.ToList(); }
        }

        public AllTasksCompany()
        {
                _allTasks = new Dictionary<Coordinations, List<WorkTask>>();
        }

        public void AddCoordinations(Coordinations coordinations)
        {
            _allTasks.Add(coordinations, new List<WorkTask>());
        }

        public void AddTask(WorkTask task)
        {
            if (_allTasks.ContainsKey(task.Coordinations))
            {
                _allTasks[task.Coordinations].Add(task);
            }
            else
            {
                throw new ArgumentException("Incorrect Coordinations");
            }
        }

        public void RemoveTask(Guid Id, Coordinations coordinations)
        {
            if (_allTasks.ContainsKey(coordinations))
            {
                for (int i = 0; i < _allTasks[coordinations].Count; i++)
                {
                    if (_allTasks[coordinations][i].GuidId == Id)
                    {
                        _allTasks[coordinations].Remove(_allTasks[coordinations][i]);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Incorrect Coordinations");
            }
        }

        public WorkTask GetTask(Guid Id, Coordinations coordinations)   //return Copy Task
        {
            if (_allTasks.ContainsKey(coordinations))
            {
                foreach (var oneTask in _allTasks[coordinations])
                {
                    if (oneTask.GuidId == Id)
                    {
                        return (WorkTask)oneTask.Clone();
                    }
                }
                return null;
            }
            else
            {
                throw new ArgumentException("Incorrect Coordinations");
            }
        }
        public List<WorkTask> GetTasks(Coordinations coordinations)     //copy collection
        {
            
            if (_allTasks.ContainsKey(coordinations))
            {
                List<WorkTask> tmpList = new List<WorkTask>();
                foreach (var task in _allTasks[coordinations])
                {
                    if (task.Status != WorkTaskStatus.Released)
                    {
                        tmpList.Add((WorkTask)task.Clone());
                    }
                }
                return tmpList;
            }
            else
            {
                throw new ArgumentException("Incorrect Coordinations");
            }
        }

        public int GetCountTasks(Coordinations coordinations)
        {
            if (_allTasks.ContainsKey(coordinations))
            {
                return _allTasks[coordinations].Count;
            }
            else
            {
                throw new ArgumentException("Incorrect Coordinations");
            }
        }
    }
}
