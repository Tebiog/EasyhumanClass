using System;
using System.Collections;

namespace SimpleOOP
{
    public class ListOfWorkers: IEnumerable
    {
        private int _counter = 0;                       //количество занятых элементов массива
        private int _capacity = 8;                      //разрядность нового путого массива
        private int _currentCapacity = 0;               //текущее количество ячеек массива
        private IWorker[] _workers;                     //массив - список сотрудников

        private enum ChoiseResize
        {
            UP,
            DOWN
        }
        public int Count
        {
            get { return _counter; }
        }

        public ListOfWorkers()
        {
            _currentCapacity = _capacity;
            _workers = new IWorker[_currentCapacity];
        }

        public void AddWorker(IWorker worker)
        {
            if (_counter == _currentCapacity)   //мест нет
            {
                Resize(ChoiseResize.UP);
            }

            _workers[_counter] = worker;
            _counter++;
        }

        public int SearchWorker(IWorker worker)               
        {
            int sIndex = -1;
            for (int i = 0; i < _counter; i++)
            {
                if (_workers[i] == worker)
                {
                    sIndex = i;
                    break;
                }
            }
            return sIndex;   //return -1 not found
        }

        public void RemoveWorker(IWorker worker)
        {
            if (_counter == 0) throw new ArgumentOutOfRangeException();

            RemoveWorker(SearchWorker(worker));
        }
        public void RemoveWorker(int delIndex)
        {
            if (delIndex < 0 || _counter == 0) throw new ArgumentOutOfRangeException();

            for (int i = delIndex; i < _counter - 1; i++)
            {
                _workers[i] = _workers[i + 1];
            }
            _workers[_counter - 1] = null;
            _counter--;

            if (_counter + _capacity - 1 < _currentCapacity - _capacity)
            {
                Resize(ChoiseResize.DOWN);
            }
        }
        private void ClearWorkers()
        {
            _counter = 0;
            _currentCapacity = _capacity;
            _workers = new IWorker[_currentCapacity];
        }

        public override string ToString()
        {
            string result = "[ ";

            foreach (var item in _workers)
            {
                result += item == null ? "* " : "# ";
            }

            result += "]";

            return result;
        }
        public IWorker this[int index]
        {
            get
            {
                if (Count > 0 && index >= 0 && index < Count)
                {
                    return _workers[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set { _workers[index] = value; }
        }
        public IWorker[] Workers
        {
            get
            {
                // return copy array of _workers 
                IWorker[] tmp = new IWorker[_counter];
                Array.Copy(_workers, tmp, _counter);
                return tmp;
            }
        }
        private void Resize(ChoiseResize resize)
        {
            IWorker[] tmp;

            switch (resize)
            {
                case ChoiseResize.UP:
                {
                    _currentCapacity += _capacity;  //увеличиваем количество текущих ячеек 
                    break; ;
                }
                case ChoiseResize.DOWN:
                {
                    if (_currentCapacity == _capacity) break;       //уменьшать меньше _capacity низзя
                    if (_counter < _currentCapacity - _capacity)    //если есть свободные _capacity ячейки
                    {
                        _currentCapacity -= _capacity;
                    }
                    else
                    {
                        throw  new ArgumentOutOfRangeException("Неконтролируемое перераспределение");
                    }
                    break;
                }
            }
            tmp = new IWorker[_currentCapacity];
            for (int i = 0; i < _counter; i++)
            {
                tmp[i] = _workers[i];
            }

            _workers = tmp;
        }

        public IEnumerator GetEnumerator()
        {
            //return _workers.GetEnumerator();    // только в стандартных случаях

            //возвращаем самописный Enumerator - при условии реализации сложной структуры данных 
            return new ListOfWorkersEnumerator(this);
        }
    }
}